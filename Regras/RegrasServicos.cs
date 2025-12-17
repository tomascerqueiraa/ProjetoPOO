using System;
using BO;
using Dados;

namespace Regras
{
    public static class RegrasServicos
    {
        /// <summary>
        /// Valida e adiciona um novo tipo de serviço ao catálogo.
        /// </summary>
        public static bool InserirServico(Servico s)
        {
            if (s == null) return false;

            // Regra 1: O serviço tem de ter um nome
            if (string.IsNullOrEmpty(s.Nome))
            {
                throw new Exception("ERRO: O serviço deve ter uma designação.");
            }

            // Regra 2: O custo não pode ser negativo
            if (s.Custo < 0)
            {
                throw new Exception("ERRO: O custo do serviço não pode ser negativo.");
            }

            // Chama a camada Dados
            return Servicos.AdicionarServico(s);
        }

        public static bool Gravar(string caminho)
        {
            return Servicos.GravarFicheiro(caminho);
        }
    }
}