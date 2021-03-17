using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanzasPersonalesProyectoFinal.Entidades
{
    public class Presupuestos
    {
        [Key]
        public int PresupuestoId { get; set; }
        public string NombrePresupuesto { get; set; }
        public int MontoPresupuesto { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int CategoriaId { get; set; }

        public Presupuestos()
        {
            PresupuestoId = 0;
            NombrePresupuesto = "";
            MontoPresupuesto = 0;
            FechaCreacion = DateTime.Now;
            CategoriaId = 0;
            Ingresos = new List<Ingresos>();
            Gastos = new List<Gastos>();
        }

        [ForeignKey("PresupuestoId")]
        public virtual List<Ingresos> Ingresos { get; set; }

        [ForeignKey("PresupuestoId")]
        public virtual List<Gastos> Gastos { get; set; }
    }
}
