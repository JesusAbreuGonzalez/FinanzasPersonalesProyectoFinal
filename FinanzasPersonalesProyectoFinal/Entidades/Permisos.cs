using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanzasPersonalesProyectoFinal.Entidades
{
    public class Permisos
    {
        [Key]
        public int PermisoId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Descripcion { get; set; }
        public int VecesAsignado { get; set; }

        public Permisos()
        {
            PermisoId = 0;
            FechaCreacion = DateTime.Now;
            Descripcion = string.Empty;
            VecesAsignado = 0;
        }

        [ForeignKey("PermisoId")]
        public virtual List<RolesDetalle> RolesDetalle { get; set; }
    }
}
