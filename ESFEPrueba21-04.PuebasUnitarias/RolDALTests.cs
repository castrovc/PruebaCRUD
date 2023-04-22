using Microsoft.VisualStudio.TestTools.UnitTesting;
using ESFEPruebaCRUD.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ESFEPruebaCRUD.EntidadesNegocio;

namespace ESFEPruebaCRUD.AccesoDatos.Tests
{
    [TestClass()]
    public class RolDALTests
    {
        private static Rol rolInicial = new Rol { Id = 2 };
        [TestMethod()]
        public void CrearAsyncTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ModificarAsyncTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarAsyncTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ObtenerPorIdAsyncTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ObtenerTodosAsyncTest()
        {
            Assert.Fail();
        }
    }
}