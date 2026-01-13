/// ============================================================================
/// Ficheiro:    RegrasFornecedores.cs
/// Projeto:     Projeto (POO - IPCA 2025/26)
/// Autor:       Tomás Afonso Cerqueira Gomes nº31501
/// Data:        2025-12-27
/// Notas:       Trabalho prático POO – Fase 2.
/// ============================================================================

using BO;
using Dados;
using System;

namespace Regras
{
    /// <summary>
    /// Classe responsável pela implementação das regras de negócio relativas aos Fornecedores.
    /// Atua como camada intermédia para validar os dados dos parceiros antes de os gravar.
    /// </summary>
    public class RegrasFornecedores
    {
        // 1. Variável privada para aceder à camada de Dados(instância)
        private Fornecedores dadosFornecedores;

        public Fornecedores DadosFornecedores
        {
            get { return this.dadosFornecedores; }
            set { this.dadosFornecedores = value; }
        }

        // 2. Construtor: Inicializa a lista/acesso aos dados
        public RegrasFornecedores()
        {
            dadosFornecedores = new Fornecedores();
        }

        /// <summary>
        /// Valida e solicita a inserção de um novo fornecedor na base de dados.
        /// </summary>
        /// <param name="f">O objeto Fornecedor a ser validado e inserido.</param>
        /// <returns>
        /// Retorna <c>true</c> se o fornecedor for inserido com sucesso;
        /// Retorna <c>false</c> se o objeto for nulo ou se a camada de dados rejeitar (ex: duplicado).
        /// </returns>
        public bool InserirFornecedor(Fornecedor f)
        {
            // 1. Validações de entrada
            if (f == null) return false;

            // 3. ALTERAÇÃO: Usa a variável 'dadosFornecedores' em vez da classe
            return dadosFornecedores.AdicionarFornecedor(f);
        }

        /// <summary>
        /// Valida o caminho e solicita a gravação da lista de fornecedores em ficheiro.
        /// </summary>
        /// <param name="caminho">O caminho ou nome do ficheiro de destino.</param>
        /// <returns>
        /// Retorna <c>true</c> se a gravação for bem-sucedida;
        /// Retorna <c>false</c> se o caminho fornecido for inválido.
        /// </returns>
        public bool Gravar(string caminho)
        {
            if (string.IsNullOrEmpty(caminho)) return false;

            // 3. ALTERAÇÃO: Usa a variável 'dadosFornecedores'
            return dadosFornecedores.GravarFicheiro(caminho);
        }
    }
}