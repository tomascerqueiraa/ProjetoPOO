using BO;
using Regras;
using System;

namespace Testes
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void InserirMaterial_ComDadosValidos_DeveRetornarVerdadeiro()
        {
            // 1. Arrange (Preparar)
            Material m = new Material("Cimento", "Saco 50kg", 12.5f);

            // 2. Act (Agir)
            bool resultado = RegrasMateriais.InserirMaterial(m);

            // 3. Assert (Verificar)
            Assert.IsTrue(resultado, "O material deveria ter sido inserido com sucesso.");
        }

    }
}
