using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanzasPersonalesProyectoFinal.Entidades
{
    public class IngresosDetalle
    {
        [Key]
        public int DetalleId { get; set; }
        public int IngresoId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public double MontoIngreso { get; set; }

        public IngresosDetalle()
        {
            DetalleId = 0;
            IngresoId = 0;
            FechaIngreso = DateTime.Now;
            MontoIngreso = 0;
        }

    }
}
