using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica.Negocio;

namespace Calculadora.test
{
    [TestClass]
    public class sumas
    {
        [TestMethod]
        public void SumarUnoMasDos()
        {
            // PASO 1.  defina el escenario de la prueba 
            var elPrimerOperando= 1;
            var elSegundoOperando = 2;
            var elResultadoEsperado = 3;

            // PASO 2. invoque al método que se desea validar
            var laSuma = new Suma();
            var elResultadoReal = laSuma.Operar(elPrimerOperando, elSegundoOperando);

            // PASO 3. comparación del resultado obtenido con el esperado 
            Assert.AreEqual(elResultadoEsperado, elResultadoReal);
        }
    }
}
