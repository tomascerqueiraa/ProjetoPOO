/// ============================================================================
/// Ficheiro:    RegrasMateriais.cs
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
    /// Classe responsável pela implementação das regras de negócio relativas aos Materiais.
    /// Serve de intermediária entre a aplicação (Front-end) e os Dados, validando a informação.
    /// </summary>
    public class RegrasMateriais
    {
        /// <summary>
        /// Valida e solicita a inserção de um novo material no catálogo da empresa.
        /// </summary>
        /// <param name="m">O objeto Material a ser inserido.</param>
        /// <returns>
        /// Retorna <c>true</c> se a inserção for bem-sucedida;
        /// Retorna <c>false</c> se o material for nulo ou se a camada de dados rejeitar a operação.
        /// </returns>
        public static bool InserirMaterial(Material m)
        {
            // 1. Validações
            if (m == null) return false;

            // 2. Chama diretamente o método estático da camada Dados
            bool suc = Materiais.AdicionarMaterial(m);
            return suc;
        }

        /// <summary>
        /// Valida o caminho do ficheiro e solicita a gravação do catálogo de materiais.
        /// </summary>
        /// <param name="caminho">O caminho ou nome do ficheiro de destino.</param>
        /// <returns>
        /// Retorna <c>true</c> se a gravação ocorrer com sucesso;
        /// Retorna <c>false</c> se o caminho fornecido for inválido.
        /// </returns>
        public static bool Gravar(string caminho)
        {
            // Valida se o caminho é válido antes de mandar gravar
            if (string.IsNullOrEmpty(caminho)) return false;

            return Materiais.GravarFicheiro(caminho);
        }
    }
}
