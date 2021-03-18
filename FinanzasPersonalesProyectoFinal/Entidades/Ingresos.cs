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
        public int PresupuestoId { get; set; }
        public string DescripcionIngreso { get; set; }

        public Ingresos()
        {
            IngresoId = 0;
            IngresosDetalle = new List<IngresosDetalle>();
            PresupuestoId = 0;
            DescripcionIngreso = string.Empty;
        }

        [ForeignKey("IngresoId")]
        public virtual List<IngresosDetalle> IngresosDetalle { get; set; }
    }
}
