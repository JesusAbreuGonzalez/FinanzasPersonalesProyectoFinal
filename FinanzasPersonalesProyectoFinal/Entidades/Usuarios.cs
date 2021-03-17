using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanzasPersonalesProyectoFinal.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Alias { get; set; }
        public string Nombres { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
        public bool Activo { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            FechaIngreso = DateTime.Now;
            Alias = string.Empty;
            Nombres = string.Empty;
            Email = string.Empty;
            Clave = string.Empty;
            Activo = false;
            Categorias = new List<Categorias>();
        }

        [ForeignKey("UsuarioId")]
        public virtual List<Categorias> Categorias { get; set; }
    }
}
