using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacturaModelo;

namespace ConsoleFactura
{
    public class Impuestos
    {
        public Nullable<decimal> baseImponible { get; set; }
        public Nullable<decimal> valor { get; set; }
        public int codigo { get; set; }
        public Nullable<int> codigoPorcentaje { get; set; }
        public Nullable<int> descuentoAdicional { get; set; }
        public string xempresa_id { get; set; }
        public string xseccion_id { get; set; }
        public string xtipodoc_id { get; set; }
        public short xciclo_id { get; set; }
        public int xnumdoc_id { get; set; }

        public Nullable<decimal> tarifa { get; set; }

        public static List<Impuestos> ObtenerImpuestos()
        {
            using (TALLERERP_A01_DATOSEntities db = new TALLERERP_A01_DATOSEntities())
            {
                return (from a in db.sdm_v_fac_iv
                        where a.xnumdoc_id == 26733 && a.xempresa_id == "ECU" && a.xseccion_id == "0" && a.xtipodoc_id == "23/A" && a.xciclo_id == 2019
                        select new Impuestos
                        {
                            baseImponible = a.baseImponible,
                            valor = a.valor,
                            codigo = a.codigo,
                            codigoPorcentaje = a.codigoPorcentaje,
                            descuentoAdicional = a.descuentoAdicional,
                            tarifa = a.tarifa
                        }).ToList();
            }
        }
    }
}
