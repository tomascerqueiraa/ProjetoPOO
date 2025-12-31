/// ============================================================================
/// Ficheiro:    Funcionarios.cs
/// Projeto:     Projeto (POO - IPCA 2025/26)
/// Autor:       Tomás Afonso Cerqueira Gomes nº31501
/// Data:        2025-12-27
/// Notas:       Trabalho prático POO – Fase 2.
/// ============================================================================

using BO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Exceptions;

namespace Dados
{
    /// <summary>
    /// Classe responsável pela gestão e persistência dos dados dos Funcionários.
    /// Gere a lista de colaboradores da empresa e permite a gravação em ficheiro.
    /// </summary>
    [Serializable]
    public class Funcionarios
    {
        private static List<Funcionario> listaFuncionarios;

        #region Construtores
        /// <summary>
        /// Construtor estático da classe Funcionarios.
        /// Inicializa a lista de funcionários antes de qualquer utilização.
        /// </summary>
        static Funcionarios()
        {
            listaFuncionarios = new List<Funcionario>();
        }
        #endregion

        #region Métodos

        /// <summary>
        /// Adiciona um novo funcionário à lista de colaboradores.
        /// </summary>
        /// <param name="f">Objeto do tipo Funcionario a adicionar.</param>
        /// <returns>
        /// Retorna <c>true</c> se o funcionário for inserido com sucesso;
        /// Retorna <c>false</c> se o objeto fornecido for nulo.
        /// </returns>
        public static bool AdicionarFuncionario(Funcionario f)
        {
            if (f == null) return false;

            listaFuncionarios.Add(f);
            return true;
        }

        /// <summary>
        /// Grava a lista atual de funcionários num ficheiro binário.
        /// </summary>
        /// <param name="caminho">Caminho ou nome do ficheiro de destino (ex: "funcionarios.bin").</param>
        /// <returns>Retorna <c>true</c> se a operação for concluída com sucesso.</returns>
        /// <exception cref="FicheiroException">
        /// Lançada quando ocorre um erro de gravação (permissões, disco cheio, etc.) ou serialização.
        /// </exception>
        public static bool GravarFicheiro(string caminho)
        {
            try
            {
                Stream stream = File.Open(caminho, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, listaFuncionarios);
                stream.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new FicheiroException("Não foi possível gravar", e);
            }
        }
        #endregion
    }
}
