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
    public class GastosBLL
    {
        public static bool ExisteGasto(string descripcion)
        {
            bool encontrado = false;
            var contexto = new Contexto();

            try
            {
                encontrado = contexto.Gastos.Any(e => e.DescripcionGasto.ToLower() == descripcion.ToLower());

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

        private static bool Insertar(Gastos gastos)
        {
            bool paso = false;
            var contexto = new Contexto();

            try
            {
                contexto.Gastos.Add(gastos);
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

        //Metodo para modificar los gastos
        private static bool Modificar(Gastos gastos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Database.ExecuteSqlRaw($"DELETE FROM GastosDetalle Where GastoId = {gastos.GastoId}");
                foreach (var anterior in gastos.GastosDetalle)
                {
                    contexto.Entry(anterior).State = EntityState.Added;
                }
                contexto.Entry(gastos).State = EntityState.Modified;
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

        public static bool Guardar(Gastos gastos)
        {
            if (!ExisteGasto(gastos.DescripcionGasto))
                return Insertar(gastos);
            else
                return Modificar(gastos);
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var eliminar = contexto.Gastos.Find(id);
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

        public static Gastos Buscar(int id)
        {
            var contexto = new Contexto();
            var gastos = new Gastos();

            try
            {
                gastos = contexto.Gastos.Include(x => x.GastosDetalle).Where(p => p.GastoId == id).SingleOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return gastos;
        }

        public static List<Gastos> GetList(Expression<Func<Gastos, bool>> criterio)
        {
            List<Gastos> lista = new List<Gastos>();
            Contexto contexto = new Contexto();
            try
            {
                //Obtenemos la lista y la filtramos segun el criterio recibido por parametro
                lista = contexto.Gastos.Where(criterio).ToList();
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

        public static List<Gastos> GetRoles()
        {
            List<Gastos> lista = new List<Gastos>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Gastos.ToList();
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
