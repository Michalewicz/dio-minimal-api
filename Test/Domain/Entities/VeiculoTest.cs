using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using minimal_api.Domain.Entities;

namespace Test.Domain.Entities
{
    public class VeiculoTest
    {
        [TestMethod]
        public void TestarGetSetPropriedades()
        {
            // Arrange
            var veiculo = new Veiculo();

            // Act
            veiculo.Id = 1;
            veiculo.Nome = "Carro";
            veiculo.Marca = "MarcaX";
            veiculo.Ano = 2020;

            // Assert
            Assert.AreEqual(1, veiculo.Id);
            Assert.AreEqual("Carro", veiculo.Nome);
            Assert.AreEqual("MarcaX", veiculo.Marca);
            Assert.AreEqual(2020, veiculo.Ano);
        }
        
    }
}