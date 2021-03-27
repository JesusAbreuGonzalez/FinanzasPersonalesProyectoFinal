using FinanzasPersonalesProyectoFinal.BLL;
using FinanzasPersonalesProyectoFinal.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanzasPersonalesProyectoFinal.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Gastos> Gastos { get; set; }
        public DbSet<Ingresos> Ingresos { get; set; }
        public DbSet<Permisos> Permisos { get; set; }
        public DbSet<Presupuestos> Presupuestos { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }

                 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlite(@"Data Source = DATA/GestionFinanzas.Db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Categorias>().HasData(
                new Categorias() { CategoriaId = 1, NombreCategoria = "Alimentación"},
                new Categorias() { CategoriaId = 2, NombreCategoria = "Educación"},
                new Categorias() { CategoriaId = 3, NombreCategoria = "Entretenimiento"},
                new Categorias() { CategoriaId = 4, NombreCategoria = "Pagos"},
                new Categorias() { CategoriaId = 5, NombreCategoria = "Ropa"},
                new Categorias() { CategoriaId = 6, NombreCategoria = "Vivienda"}
            );
                
            modelBuilder.Entity<Permisos>().HasData(
                new Permisos() { PermisoId = 1, Descripcion = "Agrega o Modifica"},
                new Permisos() { PermisoId = 2, Descripcion = "Consulta"},
                new Permisos() { PermisoId = 3, Descripcion = "Elimina"}
            );
            
            modelBuilder.Entity<RolesDetalle>().HasData(
                new RolesDetalle() { RolDetalleId = 1, RolId = 1, PermisoId = 1, EsAsignado = true}
            );
            
            modelBuilder.Entity<Roles>().HasData(
                new Roles() { RolId = 1, Descripcion = "Registrador", esActivo = true, RolesDetalle = new List<RolesDetalle>()}
            );

            modelBuilder.Entity<Usuarios>().HasData(
                new Usuarios() { UsuarioId = 1, Nombres = "Username", Clave = Utilidades.GetSHA256("username123"), Activo = true}
            );
        }
    }
}
 