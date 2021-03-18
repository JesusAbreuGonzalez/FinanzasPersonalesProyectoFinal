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
    public class PresupuestosBLL
    {
        public static bool Existe(string nombre)
        {
            bool encontrado = false;
            Contexto contexto = new Contexto();

            try
            {
                encontrado = contexto.Presupuestos.Any(e => e.NombrePresupuesto.ToLower() == nombre.ToLower());
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

        private static bool Insertar(Presupuestos presupuestos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Presupuestos.Add(presupuestos);
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

        private static bool Modificar(Presupuestos presupuestos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(presupuestos).State = EntityState.Modified;
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

        public static bool Guardar(Presupuestos presupuestos)
        {
            if (!Existe(presupuestos.NombrePresupuesto))
                return Insertar(presupuestos);
            else
                return Modificar(presupuestos);
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var presupuestos = contexto.Presupuestos.Find(id);
                if (presupuestos != null)
                {
                    contexto.Presupuestos.Remove(presupuestos);
                    paso = contexto.SaveChanges() > 0;
                }
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

        public static Presupuestos Buscar(int id)
        {
            var contexto = new Contexto();
            Presupuestos presupuestos;

            try
            {
                presupuestos = contexto.Presupuestos.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return presupuestos;
        }

        public static List<Presupuestos> GetList(Expression<Func<Presupuestos, bool>> criterio)
        {
            List<Presupuestos> lista = new List<Presupuestos>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Presupuestos.Where(criterio).ToList();
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
