using System;
using BO;
using Dados;
using Regras;
using System;

namespace Testes
{
    [TestClass]
    public class ObrasTestes
    {
        [TestMethod]
        public void CalcularCustoTotal_DeveSomarMateriaisEServicos()
        {
            // 1. Arrange (Vamos criar uma obra fictícia)
            Obra obra = new Obra("Casa Teste", "Braga", DateTime.Now, DateTime.Now.AddDays(30));

            Material m1 = new Material("Tijolo", "Unidade", 10.0f);
            Material m2 = new Material("Cimento", "Saco", 20.0f);
            Servico s1 = new Servico("Pintura", "Mão de obra", 100.0f);

            // Adicionamos os itens à obra
            obra.AdicionarMaterial(m1);
            obra.AdicionarMaterial(m2);
            obra.AdicionarServico(s1);

            // Custo esperado: 10 + 20 + 100 = 130
            double esperado = 130.0;

            // 2. Act
            double real = obra.CalcularCustoTotal();

            // 3. Assert
            Assert.AreEqual(esperado, real, "O cálculo do custo total está errado.");
        }

        [TestMethod]
        public void NovaObra_DataFimAnteriorAoInicio_DeveDarErro()
        {
            // 1. Arrange
            DateTime inicio = DateTime.Now;
            DateTime fimErrado = DateTime.Now.AddDays(-5); // Data no passado

            Obra obraInvalida = new Obra("Obra Errada", "Local", inicio, fimErrado);

            // 2. Act & Assert
            // Verifica se a camada de Regras apanha o erro da data
            Assert.ThrowsException<Exception>(() =>
            {
                RegrasObras.NovaObra(obraInvalida);
            });
        }
    }
}
