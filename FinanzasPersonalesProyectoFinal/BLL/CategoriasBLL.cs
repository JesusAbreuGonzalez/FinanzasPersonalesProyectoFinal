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
    public class CategoriasBLL
    { 
        public static bool Existe(string nombre)
        {
            bool encontrado = false;
            Contexto contexto = new Contexto();

            try
            {
                encontrado = contexto.Categorias.Any(e => e.NombreCategoria.ToLower() == nombre.ToLower());
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

        private static bool Insertar(Categorias categorias)
        {
            bool paso = false;
            var contexto = new Contexto();

            try
            {
                contexto.Categorias.Add(categorias);
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

        private static bool Modificar(Categorias categorias)
        {
            bool paso = false;
            var contexto = new Contexto();

            try
            {
                contexto.Entry(categorias).State = EntityState.Modified;
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

        public static bool Guardar(Categorias categorias)
        {
            if (!Existe(categorias.NombreCategoria))
                return Insertar(categorias);
            else
                return Modificar(categorias);
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            var contexto = new Contexto();

            try
            {
                var categorias = contexto.Categorias.Find(id);
                if(categorias != null)
                {
                    contexto.Categorias.Remove(categorias);
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

        public static Categorias Buscar(int id)
        {
            var contexto = new Contexto();
            Categorias categorias;

            try
            {
                categorias = contexto.Categorias.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return categorias;
        }

        public static List<Categorias> GetList(Expression<Func<Categorias, bool>> criterio)
        {
            List<Categorias> lista = new List<Categorias>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Categorias.Where(criterio).ToList();
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
