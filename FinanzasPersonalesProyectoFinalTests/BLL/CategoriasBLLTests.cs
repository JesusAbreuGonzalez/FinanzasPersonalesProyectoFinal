using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinanzasPersonalesProyectoFinal.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanzasPersonalesProyectoFinal.Entidades;

namespace FinanzasPersonalesProyectoFinal.BLL.Tests
{
    [TestClass()]
    public class CategoriasBLLTests
    {
        [TestMethod()]
        public void ExisteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GuardarTest()
        {
            var categorias = new Categorias();
            categorias.CategoriaId = 1;
            categorias.NombreCategoria = "Alimentación";
            categorias.FechaCreacion = DateTime.Now;

            var paso = CategoriasBLL.Guardar(categorias);
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetCategoriasTest()
        {
            Assert.Fail();
        }
    }
}