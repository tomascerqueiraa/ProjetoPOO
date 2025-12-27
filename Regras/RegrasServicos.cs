/// ============================================================================
/// Ficheiro:    RegrasServicos.cs
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
    /// Classe responsável pela implementação das regras de negócio relativas aos Serviços.
    /// Valida os dados dos serviços (como nome e custo) antes de permitir o seu registo na base de dados.
    /// </summary>
    public static class RegrasServicos
    {
        /// <summary>
        /// Valida os dados de um serviço e, se corretos, solicita a sua inserção na camada de Dados.
        /// </summary>
        /// <param name="s">O objeto Serviço a validar e inserir.</param>
        /// <returns>
        /// Retorna <c>true</c> se a inserção for bem-sucedida;
        /// Retorna <c>false</c> se o objeto serviço for nulo.
        /// </returns>
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

        /// <summary>
        /// Solicita a gravação dos dados dos serviços em ficheiro através da camada de Dados.
        /// </summary>
        /// <param name="caminho">O caminho ou nome do ficheiro de destino.</param>
        /// <returns>Retorna <c>true</c> se a operação for concluída com sucesso.</returns>
        public static bool Gravar(string caminho)
        {
            return Servicos.GravarFicheiro(caminho);
        }
    }
}