using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcial1_Ap2_Padilla.BLL;
using Parcial1_Ap2_Padilla.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1_Ap2_Padilla.BLL.Tests
{
    [TestClass()]
    public class ArticulosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Articulos articulo = new Articulos();

            articulo.ProductoId = 0;
            articulo.Descripcion = "Lapiz";
            articulo.Existencia = 5;
            articulo.Costo = 10;

            Assert.AreEqual(paso, true);
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
        public void ExisteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest1()
        {
            Assert.Fail();
        }
    }
}