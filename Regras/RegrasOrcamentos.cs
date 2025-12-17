using System;
using BO;
using Dados;

namespace Regras
{
    public static class RegrasOrcamentos
    {
        /// <summary>
        /// Valida e regista um orçamento.
        /// </summary>
        public static bool NovoOrcamento(Orcamento o)
        {
            if (o == null) return false;

            // Regra 1: O orçamento precisa de um código identificador
            if (string.IsNullOrEmpty(o.Codigo))
            {
                throw new Exception("ERRO: O orçamento deve ter um código único.");
            }

            // Regra 2: O valor total não pode ser negativo
            if (o.CustoTotal < 0)
            {
                throw new Exception("ERRO: O valor total do orçamento não pode ser negativo.");
            }

            // Regra 3: Valida a data (opcional, mas boa prática)
            if (o.DataCriacao == DateTime.MinValue)
            {
                // Se a data não foi preenchida, atribuímos a data de hoje automaticamente
                o.DataCriacao = DateTime.Now;
            }

            // Chama a camada Dados
            return Orcamentos.AdicionarOrcamento(o);
        }

        public static bool Gravar(string caminho)
        {
            return Orcamentos.GravarFicheiro(caminho);
        }
    }
}