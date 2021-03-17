using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanzasPersonalesProyectoFinal.Entidades
{
    public class GastosDetalle
    {
        [Key]
        public int DetalleId { get; set; }
        public int GastoId { get; set; }
        public DateTime FechaGasto { get; set; }
        public double MontoGasto { get; set; }

        public GastosDetalle()
        {
            DetalleId = 0;
            GastoId = 0;
            FechaGasto = DateTime.Now;
            MontoGasto = 0;
        }
    }
}
