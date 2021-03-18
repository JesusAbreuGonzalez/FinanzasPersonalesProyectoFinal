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
        public DbSet<GastosDetalle> GastosDetalle { get; set; }
        public DbSet<Ingresos> Ingresos { get; set; }
        public DbSet<IngresosDetalle> IngresosDetalle { get; set; }
        public DbSet<Permisos> Permisos { get; set; }
        public DbSet<Presupuestos> Presupuestos { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<RolesDetalle> RolesDetalle { get; set; }
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
        }
    }
}
