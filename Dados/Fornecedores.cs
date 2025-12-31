/// ============================================================================
/// Ficheiro:    Fornecedores.cs
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
    /// Classe responsável pela gestão e persistência dos dados dos Fornecedores.
    /// Mantém uma lista em memória de todos os fornecedores e permite a sua gravação em ficheiro.
    /// </summary>
    [Serializable]
    public class Fornecedores
    {
        private static List<Fornecedor> listaFornecedores;

        #region Construtores
        /// <summary>
        /// Construtor estático da classe Fornecedores.
        /// Corre apenas uma vez para inicializar a lista antes de qualquer utilização.
        /// </summary>
        static Fornecedores()
        {
            listaFornecedores = new List<Fornecedor>();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Adiciona um novo fornecedor à lista, verificando se é válido e se não é duplicado.
        /// </summary>
        /// <param name="f">Objeto do tipo Fornecedor a adicionar.</param>
        /// <returns>
        /// Retorna <c>true</c> se o fornecedor for adicionado com sucesso;
        /// Retorna <c>false</c> se o objeto for nulo ou se já existir na lista.
        /// </returns>
        public static bool AdicionarFornecedor(Fornecedor f)
        {
            if (f == null) return false;

            // Verifica se o fornecedor já existe (baseado no Equals do objeto)
            if (listaFornecedores.Contains(f)) return false;

            listaFornecedores.Add(f);
            return true;
        }

        /// <summary>
        /// Grava a lista atual de fornecedores num ficheiro binário.
        /// </summary>
        /// <param name="caminho">O caminho ou nome do ficheiro de destino (ex: "fornecedores.bin").</param>
        /// <returns>Retorna <c>true</c> se a gravação for concluída com sucesso.</returns>
        /// <exception cref="FicheiroException">
        /// Lançada caso ocorra um erro de I/O ou serialização durante o processo de gravação.
        /// </exception>
        public static bool GravarFicheiro(string caminho)
        {
            try
            {
                Stream stream = File.Open(caminho, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();

                bin.Serialize(stream, listaFornecedores);

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