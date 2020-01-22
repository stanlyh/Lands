using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacturaModelo;
using System.Xml.Linq;
using ConsoleFactura.RecepcionComprobantesOffline;
using ConsoleFactura.AutorizacionComprobantesOffline;
using System.Text.RegularExpressions;
using System.Reflection;
using System.IO;

namespace ConsoleFactura
{
    class Program
    {
        static void Main(string[] args)
        {
            TALLERERP_A01_DATOSEntities entidades = new TALLERERP_A01_DATOSEntities();

            List<sdm_v_fac_cab> faccab = entidades.sdm_v_fac_cab.ToList<sdm_v_fac_cab>();
            List<sdm_v_fac_lin> faclin = entidades.sdm_v_fac_lin.ToList<sdm_v_fac_lin>();
            List<sdm_v_fac_iv> faciv = entidades.sdm_v_fac_iv.ToList<sdm_v_fac_iv>();

            var lin = faclin.Where(x => x.xnumdoc_id == 26733 && x.xempresa_id == "ECU").ToList();

            XDocument xml = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                from f in faccab
                where f.xnumdoc_id == 26733 && f.xempresa_id == "ECU" && f.xseccion_id == "0" && f.xtipodoc_id == "23/A" && f.xciclo_id == 2019
                select
                new XElement("factura",
                    new XElement("infoTributaria",
                        new XElement("ambiente", "1"),
                        new XElement("tipoEmision", "1"),
                        new XElement("razonSocial", f.razonSocial),
                        new XElement("nombreComercial", f.nombreComercial),
                        new XElement("ruc", f.ruc),
                        new XElement("claveAcceso", f.preClaveAcceso),//"000000000000000000000000000000000000000000000000000"),
                        new XElement("codDoc", f.codDoc),
                        new XElement("estab", f.estab),
                        new XElement("secuencial", f.secuencial),
                        new XElement("dirMatriz", f.dirMatriz)
                    ),
                    new XElement("infoFactura",
                        new XElement("fechaEmision", f.fechaEmision),
                        new XElement("dirEstablecimiento", f.dirEstablecimiento),
                        new XElement("contribuyenteEspecial", f.contribuyenteEspecial), //TODO
                        new XElement("obligadoContabilidad", f.obligadoContabilidad),
                        new XElement("tipoIdentificacionComprador", f.tipoIdentificacionComprador),
                        new XElement("razonSocialComprador", f.razonSocialComprador),
                        new XElement("identificacionComprador", f.identificacionComprador),
                        new XElement("totalSinImpuestos", f.totalSinImpuestos),
                        new XElement("totalDescuento", f.totalDescuento),
                        new XElement("totalConImpuestos",
                                from i in Impuestos.ObtenerImpuestos()                                
                                select
                                new XElement("totalImpuesto",
                                new XElement("codigo", i.codigo),
                                new XElement("codigoPorcentaje", i.codigoPorcentaje),
                                //new XElement("descuentoAdicional", i.descuentoAdicional),
                                new XElement("baseImponible", i.baseImponible),
                                new XElement("tarifa", i.tarifa), 
                                new XElement("valor", i.valor)
                            )
                        ),
                        new XElement("propina", f.propina),
                        new XElement("importeTotal", f.importeTotal),
                        new XElement("moneda", f.moneda),
                        new XElement("pagos",
                            new XElement("pago",
                                new XElement("formaPago", f.formaPago),
                                new XElement("total", f.total),
                                new XElement("plazo", f.plazo),
                                new XElement("unidadTiempo", f.unidadTiempo)
                            )
                        )
                    ),
                    new XElement("detalles",
                        from d in Detalles.ObtenerDetalles()                        
                        select           
                        new XElement("detalle",           
                            new XElement("codigoPrincipal", d.codigoPrincipal),
                            //new XElement("codigoAuxiliar", d.codigoAuxiliar),
                            new XElement("descripcion", d.descripcion),
                            new XElement("cantidad", d.cantidad),
                            new XElement("precioUnitario", d.precioUnitario),
                            new XElement("descuento", d.descuento),
                            new XElement("precioTotalSinImpuesto", d.precioTotalSinImpuesto),
                            new XElement("detallesAdicionales",
                                new XElement("detAdicional", new XAttribute("nombre", d.detAdicionalNombre1), d.detAdicionalValor1),
                                new XElement("detAdicional", new XAttribute("nombre", d.detAdicionalNombre2), d.detAdicionalValor2)
                            )
                        )                
                    ),
                    new XElement("infoAdicional",
                        new XElement("campoAdicional", new XAttribute("nombre",f.infoAdicionalNombre1), f.infoAdicionalValor1),
                        new XElement("campoAdicional", new XAttribute("nombre", f.infoAdicionalNombre2), f.infoAdicionalValor2)
                    )
                )                
            );//Factura
            xml.Save("Factura.xml");
            //xml.Save(@"D:\Generados\Factura.xml");

            //XDocument xml_d = new XDocument(
            //    new XElement(lin.GetType().Name,             // Nodo raiz
            //        from tipoMiembro in Enum.GetValues(typeof(MemberTypes)).Cast<MemberTypes>()
            //        select new XElement(tipoMiembro.ToString() + "Member")     // Cada iteración devolverá un nuevo nodo
            //    )
            //);

            //XDocument xml_d = new XDocument(
            //    new XElement("detalle",             // Nodo raiz
            //        from k in lin.GetType().GetMembers()
            //        select 
            //        new XElement(k.ToString(), "Member")     // Cada iteración devolverá un nuevo nodo
            //    )
            //);

            XElement xml_d = new XElement("detalle");
            foreach (var l in lin) { 
                xml_d.Add(new XElement("codigoPrincipal", l.codigoPrincipal));
                xml_d.Add(new XElement("descripcion", l.descripcion));
                xml_d.Add(new XElement("cantidad", l.cantidad));
                xml_d.Add(new XElement("precioUnitario", l.precioUnitario));
                xml_d.Add(new XElement("descuento", l.descuento));
                xml_d.Add(new XElement("precioTotalSinImpuesto", l.precioTotalSinImpuesto));
                XElement detallesAdicionales = new XElement("detallesAdicionales");
                detallesAdicionales.Add(new XElement("detAdicional", new XAttribute("nombre", l.detAdicionalNombre1), l.detAdicionalValor1));
                detallesAdicionales.Add(new XElement("detAdicional", new XAttribute("nombre", l.detAdicionalNombre2), l.detAdicionalValor2));
                xml_d.Add(detallesAdicionales);
            }
            //xml_d.Save("Factura_d.xml");

            //RecepcionComprobantesOffline.RecepcionComprobantesOfflineClient ws = new RecepcionComprobantesOffline.RecepcionComprobantesOfflineClient();

        }

        private static string CreateDigit11(string verifierString)
        {
            int baseMax = 7;
            int multiplicador = 2;
            int total = 0;
            int verificador = 0;
            int numAux = 0;

            string[] substrings = Regex.Split(verifierString, "");

            for (int i = substrings.Length - 1; i >= 1; i--)
                if (substrings[i] != "")
                {
                    if (multiplicador > baseMax)
                        multiplicador = 2;

                    numAux = int.Parse(substrings[i]);
                    total = total + (numAux * multiplicador);
                    multiplicador = multiplicador + 1;
                }

            verificador = 11 - (total % 11);

            if (verificador == 10)
                verificador = 1;
            else
            if (verificador == 11)
                verificador = 0;

            return verificador.ToString();
        }
    }
}
