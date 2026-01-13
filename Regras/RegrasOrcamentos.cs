/// ============================================================================
/// Ficheiro:    RegrasOrcamentos.cs
/// Projeto:     Projeto (POO - IPCA 2025/26)
/// Autor:       Tomás Afonso Cerqueira Gomes nº31501
/// Data:        2025-12-27
/// Notas:       Trabalho prático POO – Fase 2.
/// ============================================================================

using System;
using BO;
using Dados;

namespace Regras
{
    /// <summary>
    /// Classe responsável pela implementação das regras de negócio relativas aos Orçamentos.
    /// Garante que os orçamentos cumprem os requisitos (como ter código e valores válidos) antes de serem registados.
    /// </summary>
    public class RegrasOrcamentos
    {
        // 1. Variável privada para aceder à camada de Dados (instância)
        private Orcamentos dadosOrcamentos;

        public Orcamentos DadosOrcamentos
        {
            get { return this.dadosOrcamentos; }
            set { this.dadosOrcamentos = value; }
        }

        // 2. Construtor: Inicializa a lista/acesso aos dados
        public RegrasOrcamentos()
        {
            dadosOrcamentos = new Orcamentos();
        }

        /// <summary>
        /// Valida os dados de um orçamento e, se corretos, submete-o para registo na camada de Dados.
        /// </summary>
        /// <param name="o">O objeto Orçamento a validar.</param>
        /// <returns>
        /// Retorna <c>true</c> se o orçamento for registado com sucesso;
        /// Retorna <c>false</c> se o objeto fornecido for nulo.
        /// </returns>
        public bool NovoOrcamento(Orcamento o)
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

            // Regra 3: Valida a data
            if (o.DataCriacao == DateTime.MinValue)
            {
                // Se a data não foi preenchida, atribuímos a data de hoje automaticamente
                o.DataCriacao = DateTime.Now;
            }

            // 3. ALTERAÇÃO: Chama a instância 'dadosOrcamentos' em vez da classe estática
            return dadosOrcamentos.AdicionarOrcamento(o);
        }

        /// <summary>
        /// Solicita a gravação da lista de orçamentos em ficheiro.
        /// </summary>
        /// <param name="caminho">O caminho ou nome do ficheiro de destino.</param>
        /// <returns>Retorna <c>true</c> se a operação for bem-sucedida.</returns>
        public bool Gravar(string caminho)
        {
            // 3. ALTERAÇÃO: Usa a variável 'dadosOrcamentos'
            return dadosOrcamentos.GravarFicheiro(caminho);
        }
    }
}