/// ============================================================================
/// Ficheiro:    RegrasFuncionarios.cs
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
    /// Classe responsável pela implementação das regras de negócio relativas aos Funcionários.
    /// Valida os dados pessoais e contratuais dos colaboradores antes de permitir o seu registo.
    /// </summary>
    public static class RegrasFuncionarios
    {
        /// <summary>
        /// Valida os dados de um novo funcionário e, se corretos, solicita o registo na camada de Dados.
        /// </summary>
        /// <param name="f">O objeto Funcionario a validar e registar.</param>
        /// <returns>
        /// Retorna <c>true</c> se o funcionário for registado com sucesso;
        /// Retorna <c>false</c> se o objeto fornecido for nulo.
        /// </returns>
        public static bool RegistarFuncionario(Funcionario f)
        {
            // 1. Validações
            if (f == null) return false;

            // Regra: Nome obrigatório
            if (string.IsNullOrEmpty(f.NomeF))
            {
                throw new Exception("ERRO: O funcionário tem de ter um nome.");
            }

            // Regra: Deve ter uma função/cargo atribuído
            if (string.IsNullOrEmpty(f.Funcao))
            {
                throw new Exception("ERRO: É necessário definir a função do funcionário.");
            }

            // Regra: O salário não pode ser negativo ou zero
            if (f.Salario <= 0)
            {
                throw new Exception("ERRO: O salário deve ser um valor positivo.");
            }

            return Funcionarios.AdicionarFuncionario(f);
        }

        /// <summary>
        /// Solicita a gravação da lista de funcionários em ficheiro.
        /// </summary>
        /// <param name="caminho">O caminho ou nome do ficheiro de destino.</param>
        /// <returns>Retorna <c>true</c> se a operação for concluída com sucesso.</returns>
        public static bool Gravar(string caminho)
        {
            return Funcionarios.GravarFicheiro(caminho);
        }
    }
}