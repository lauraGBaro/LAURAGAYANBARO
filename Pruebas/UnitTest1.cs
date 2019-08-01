using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServicioWeb.Modelo;

namespace Pruebas
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodCamposNoVaciosNiCaracteresEspecialesForm()
        {
            List<string> datos = new List<string>();
            datos.Add("rebelde$$$!!!");
            datos.Add("");

            List<bool> resultadoErrores = ClienteImperio.Shared.Utiles.ValidacionEntradaDatos(datos);

            Assert.IsTrue(resultadoErrores.Contains(true));
            Assert.IsTrue(resultadoErrores.Count == datos.Count);
        }


        [TestMethod]
        public void TestMethodCamposNoVaciosNiCaracteresEspecialesServicio()
        {
            string datos = "rebelde,marte";

            var resultado = ServicioWeb.Shared.Utiles.ValidacionDatos(datos);

            Assert.IsTrue(resultado);
        }


        [TestMethod]
        public void TestMethodRegistroFicheroServicio()
        {
            var respuesta = Fichero.Instance().RegistroFichero("Rebeld rebelde on marte at 01:30:00 - 01/08/2019");

            Assert.IsTrue(respuesta);
        }

       

     

    }
}
