using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacturaModelo;

namespace ConsoleFactura
{
    public class Detalles
    {
        public string codigoPrincipal { get; set; }
        public string codigoAuxiliar { get; set; }
        public string descripcion { get; set; }
        public Nullable<decimal> cantidad { get; set; }
        public Nullable<decimal> precioUnitario { get; set; }
        public Nullable<decimal> descuento { get; set; }
        public Nullable<decimal> precioTotalSinImpuesto { get; set; }
        public Nullable<int> codigo { get; set; }
        public Nullable<int> codigoPorcentaje { get; set; }
        public Nullable<decimal> tarifa { get; set; }
        public Nullable<decimal> baseImponible { get; set; }
        public Nullable<decimal> valor { get; set; }
        public string detAdicionalNombre1 { get; set; }
        public string detAdicionalValor1 { get; set; }
        public string detAdicionalNombre2 { get; set; }
        public string detAdicionalValor2 { get; set; }
        public string detAdicionalNombre3 { get; set; }
        public string detAdicionalValor3 { get; set; }
        public int xnumdoc_id { get; set; }
        public string xtipodoc_id { get; set; }
        public string xseccion_id { get; set; }
        public string xempresa_id { get; set; }
        public short xciclo_id { get; set; }

        public static List<Detalles> ObtenerDetalles()
        {
            using (TALLERERP_A01_DATOSEntities db = new TALLERERP_A01_DATOSEntities())
            {
                return (from a in db.sdm_v_fac_lin
                        where a.xnumdoc_id == 26733 && a.xempresa_id == "ECU" && a.xseccion_id == "0" && a.xtipodoc_id == "23/A" && a.xciclo_id == 2019
                        select new Detalles
                        {
                            codigoPrincipal = a.codigoPrincipal,
                            codigoAuxiliar = a.codigoAuxiliar,
                            descripcion = a.descripcion,
                            cantidad = a.cantidad,
                            precioUnitario = a.precioUnitario,
                            descuento = a.descuento,
                            precioTotalSinImpuesto = a.precioTotalSinImpuesto,
                            codigo = a.codigo,
                            codigoPorcentaje = a.codigoPorcentaje,
                            tarifa = a.tarifa,
                            baseImponible = a.baseImponible,
                            valor = a.valor,
                            detAdicionalNombre1 = a.detAdicionalNombre1,
                            detAdicionalValor1 = a.detAdicionalValor1,
                            detAdicionalNombre2 = a.detAdicionalNombre2,
                            detAdicionalValor2 = a.detAdicionalValor2,
                            detAdicionalNombre3 = a.detAdicionalNombre3,
                            detAdicionalValor3 = a.detAdicionalValor3,
                        }).ToList();
            }
        }
    }
}
