/// ============================================================================
/// Ficheiro:    RegrasObras.cs
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
    /// Classe responsável pela implementação das regras de negócio relativas às Obras.
    /// Valida os dados fundamentais de uma obra (nome, local, datas) antes de permitir o seu registo.
    /// </summary>
    public class RegrasObras
    {
        // 1. Variável privada para aceder à camada de Dados (instância)
        private Obras dadosObras;

        public Obras DadosObras
        {
            get { return this.dadosObras; }
            set { this.dadosObras = value; }
        }

        // 2. Construtor: Inicializa a lista/acesso aos dados
        public RegrasObras()
        {
            dadosObras = new Obras();
        }

        /// <summary>
        /// Valida os dados de uma nova obra e, se cumprirem as regras, submete-a para registo na camada de Dados.
        /// </summary>
        /// <param name="o">O objeto Obra a validar e inserir.</param>
        /// <returns>
        /// Retorna <c>true</c> se a obra for inserida com sucesso;
        /// Retorna <c>false</c> se o objeto obra for nulo ou se a inserção na camada de dados falhar (ex: duplicado).
        /// </returns>
        public bool NovaObra(Obra o)
        {
            if (o == null) return false;

            // Regra 1: Nome da obra é obrigatório
            if (string.IsNullOrEmpty(o.Nome))
            {
                throw new Exception("ERRO: A obra tem de ter um nome ou identificação.");
            }

            // Regra 2: Localização é obrigatória
            if (string.IsNullOrEmpty(o.Localizacao))
            {
                throw new Exception("ERRO: Indique a localização da obra.");
            }

            // Regra 3: A data de fim não pode ser anterior à data de início
            if (o.DataFimPrevisto < o.DataInicio)
            {
                throw new Exception("ERRO: A data de conclusão prevista não pode ser anterior à data de início.");
            }

            // 3. ALTERAÇÃO: Chama a instância 'dadosObras' em vez da classe estática
            return dadosObras.InsereObra(o);
        }

        /// <summary>
        /// Solicita a gravação da lista de obras em ficheiro através da camada de Dados.
        /// </summary>
        /// <param name="caminho">O caminho ou nome do ficheiro de destino.</param>
        /// <returns>Retorna <c>true</c> se a operação for concluída com sucesso.</returns>
        public bool Gravar(string caminho)
        {
            // 3. ALTERAÇÃO: Usa a variável 'dadosObras'
            return dadosObras.GravarFicheiro(caminho);
        }
    }
}