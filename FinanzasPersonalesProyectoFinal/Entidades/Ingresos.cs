using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanzasPersonalesProyectoFinal.Entidades
{
    public class Ingresos
    {
        [Key]
        public int IngresoId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public double MontoIgreso { get; set; }
        public int PresupuestoId { get; set; }

        public Ingresos()
        {
            IngresoId = 0;
            FechaIngreso = DateTime.Now;
            MontoIgreso = 0;
            IngresosDetalle = new List<IngresosDetalle>();
            PresupuestoId = 0;
        }

        [ForeignKey("IngresoId")]
        public virtual List<IngresosDetalle> IngresosDetalle { get; set; }
    }
}
