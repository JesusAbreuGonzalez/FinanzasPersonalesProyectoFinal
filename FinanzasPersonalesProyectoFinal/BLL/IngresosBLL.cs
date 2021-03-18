using FinanzasPersonalesProyectoFinal.DAL;
using FinanzasPersonalesProyectoFinal.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FinanzasPersonalesProyectoFinal.BLL
{
    public class IngresosBLL
    {
        public static bool Existe(string descripcion)
        {
            bool encontrado = false;
            var contexto = new Contexto();

            try
            {
                encontrado = contexto.Ingresos.Any(e => e.DescripcionIngreso.ToLower() == descripcion.ToLower());

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return encontrado;
        }

        private static bool Insertar(Ingresos ingresos)
        {
            bool paso = false;
            var contexto = new Contexto();

            try
            {
                contexto.Ingresos.Add(ingresos);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        //Metodo para modificar los ingresos
        private static bool Modificar(Ingresos ingresos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Database.ExecuteSqlRaw($"DELETE FROM GastosDetalle Where GastoId = {ingresos.IngresoId}");
                foreach (var anterior in ingresos.IngresosDetalle)
                {
                    contexto.Entry(anterior).State = EntityState.Added;
                }
                contexto.Entry(ingresos).State = EntityState.Modified;
                paso = (contexto.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;

        }

        public static bool Guardar(Ingresos ingresos)
        {
            if (!Existe(ingresos.DescripcionIngreso))
                return Insertar(ingresos);
            else
                return Modificar(ingresos);
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var eliminar = contexto.Ingresos.Find(id);
                contexto.Entry(eliminar).State = EntityState.Deleted;

                paso = (contexto.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static Ingresos Buscar(int id)
        {
            var contexto = new Contexto();
            var ingresos = new Ingresos();

            try
            {
                ingresos = contexto.Ingresos.Include(x => x.IngresosDetalle).Where(p => p.IngresoId == id).SingleOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return ingresos;
        }

        public static List<Ingresos> GetList(Expression<Func<Ingresos, bool>> criterio)
        {
            List<Ingresos> lista = new List<Ingresos>();
            Contexto contexto = new Contexto();
            try
            {
                //Obtenemos la lista y la filtramos segun el criterio recibido por parametro
                lista = contexto.Ingresos.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }

        public static List<Ingresos> GetIngreso()
        {
            List<Ingresos> lista = new List<Ingresos>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Ingresos.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }
    }
}
