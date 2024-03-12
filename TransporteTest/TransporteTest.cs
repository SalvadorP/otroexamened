using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PracticaExamenED;

namespace TransporteTest
{
    [TestClass]
    public class TransporteTest
    {
        [TestMethod]
        [DataRow("Juan", -1, 20, 2)]
        [DataRow("Ana", -2, 20, 3)]
        [DataRow("Luis", -0, 50, 1)]
        public void ValidaCalcularParadasPaqueteNoValido(string conductor, int paquete, double pesoCarga, int ruta)
        {
            try
            {
                RMB2324_Transporte transporte = new RMB2324_Transporte(conductor, paquete, pesoCarga, ruta);
                transporte.CalcularParadas();

                Console.WriteLine(conductor + ", " + paquete + ", " + pesoCarga + ", " + ruta);
            }
            catch (ArgumentOutOfRangeException error)
            {
                StringAssert.Contains(error.Message, RMB2324_Transporte.ERROR_PAQUETES);
                return;
            }
            Assert.Fail("Error. Se debería haber producido una excepción.");
        }

        [TestMethod]
        [DataRow("Lucas", 200, 60, -1)]
        [DataRow("Pedro", 40, 30, -2)]
        [DataRow("Cristina", 20, 100, 0)]
        public void ValidarCalcularParadasRutaNoValida(string conductor, int paquete, double pesoCarga, int ruta)
        {
            try
            {
                RMB2324_Transporte transporte = new RMB2324_Transporte(conductor, paquete, pesoCarga, ruta);
                transporte.CalcularParadas();

                Console.WriteLine(conductor + ", " + paquete + ", " + pesoCarga + ", " + ruta);
            }
            catch (ArgumentOutOfRangeException error)
            {
                StringAssert.Contains(error.Message, RMB2324_Transporte.ERROR_RUTA);
                return;
            }
            Assert.Fail("Error. Se debía haber producido una excepción.");
        }

        [TestMethod]
        [DataRow("Eva", 10, 200, 20)]
        [DataRow("Carmen", 1, 1, 0.01)]
        public void ValidarCalcularKmPorRuta(string conductor, int paquete, double pesoCarga, double kmEsperados)
        {
            RMB2324_Transporte transporte = new RMB2324_Transporte();
            transporte.Conductor = conductor;
            transporte.Paquete = paquete;
            transporte.PesoCarga = pesoCarga;

            Console.WriteLine(conductor + ", " + paquete + ", " + pesoCarga + ", " + kmEsperados);

            Assert.AreEqual(kmEsperados, transporte.CalcularKilometrosPorRuta());
        }
    }
}
