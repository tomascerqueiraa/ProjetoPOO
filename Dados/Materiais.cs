/// ============================================================================
/// Ficheiro:    Materiais.cs
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
using static Exceptions.FicheiroExcecoes;


namespace Dados
{
    /// <summary>
    /// Classe responsável pela gestão do catálogo de Materiais da empresa.
    /// Permite adicionar novos materiais à memória e gravar a lista em ficheiro.
    /// </summary>
    [Serializable]
    public class Materiais
    {
        private static List<Material> listaMateriais;

        #region Construtores
        /// <summary>
        /// Construtor estático da classe Materiais.
        /// Inicializa a lista de materiais para que esteja pronta a ser usada.
        /// </summary>
        static Materiais()
        {
            listaMateriais = new List<Material>();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Adiciona um novo material ao catálogo da empresa.
        /// </summary>
        /// <param name="m">Objeto do tipo Material a adicionar.</param>
        /// <returns>
        /// Retorna <c>true</c> se o material for adicionado com sucesso;
        /// Retorna <c>false</c> se o material for nulo.
        /// </returns>
        public static bool AdicionarMaterial(Material m)
        {
            if (m == null) return false;
            if (m == null) return false;
            listaMateriais.Add(m);
            return true;
        }

        /// <summary>
        /// Grava o catálogo de materiais num ficheiro binário.
        /// </summary>
        /// <param name="caminho">O caminho ou nome do ficheiro (ex: "stocks.bin").</param>
        /// <returns>Retorna <c>true</c> se a operação for bem sucedida.</returns>
        /// <exception cref="FicheiroException">
        /// Lançada em caso de erro no acesso ao disco ou durante a serialização.
        /// </exception>
        public static bool  GravarFicheiro(string caminho)
        {
            try
            {
                Stream stream = File.Open(caminho, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, listaMateriais);
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
