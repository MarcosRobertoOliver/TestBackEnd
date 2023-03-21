using Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIMC
{
    [TestClass]
    public class CalculoIMCTestes
    {
        [TestMethod]
        public void CalculoIMC()
        {
            //Arrange - Preparação
            double peso = 110;
            Double altura = 1.79;

            //Act - Ação
            var resultadoIMC = Operacoes.CalcularIMC(peso, altura);
            //Assert - verificação
            Assert.AreEqual(34.33, resultadoIMC);
        }
    }
}
