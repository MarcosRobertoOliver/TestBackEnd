using Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIMC
{
    [TestClass]
    public class ClassificarIMCTest
    {
        [TestMethod]
        public void ClassificarIMC()
        {
            //Arrange - Preparação
            double imc = 28;
            //Act - Ação
            var classificacaoIMC = Operacoes.ClassificarIMC(imc);
            //Arrange - verificação
            Assert.AreEqual("Sobrepeso", classificacaoIMC);
        }
    }
}
