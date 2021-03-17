using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanzasPersonalesProyectoFinal.Entidades
{
    public class Categorias
    {
        [Key]
        public int CategoriaId { get; set; }
        public string NombreCategoria { get; set; }

        public Categorias()
        {
            CategoriaId = 0;
            NombreCategoria = "";
            Presupuestos = new List<Presupuestos>();
        }

        [ForeignKey("CategoriaId")]
        public virtual List<Presupuestos> Presupuestos { get; set; }
    }
}