using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanzasPersonalesProyectoFinal.Entidades
{
    public class Gastos
    {
        [Key]
        public int GastoId { get; set; }
        public string DescripcionGasto { get; set; }
        public int PresupuestoId { get; set; }

        public Gastos()
        {
            GastoId = 0;
            DescripcionGasto = string.Empty;
            GastosDetalle = new List<GastosDetalle>();
            PresupuestoId = 0;
        }

        [ForeignKey("GastoId")]
        public virtual List<GastosDetalle> GastosDetalle { get; set; }
    }
}
