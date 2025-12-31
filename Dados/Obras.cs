/// ============================================================================
/// Ficheiro:    Obras.cs
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
    /// Classe responsável pela gestão e persistência das Obras de construção.
    /// Armazena a lista de todas as obras registadas e gere a gravação em ficheiro.
    /// </summary>
    [Serializable]
    public class Obras
    {
        static List<Obra> ListaObras;

        #region Construtores
        /// <summary>
        /// Construtor estático da classe Obras.
        /// Inicializa a lista de obras vazia para evitar referências nulas.
        /// </summary>
        static Obras()
        {
            ListaObras = new List<Obra>();
        }
        #endregion

        #region Métodos

        /// <summary>
        /// Insere uma nova obra na lista de registos, caso esta ainda não exista.
        /// </summary>
        /// <param name="a">Objeto do tipo Obra a ser inserido.</param>
        /// <returns>
        /// Retorna <c>true</c> se a obra for inserida com sucesso;
        /// Retorna <c>false</c> se a obra já existir na lista.
        /// </returns>
        public static bool InsereObra(Obra a)
        {
            if (ListaObras.Contains(a)) return false;

            ListaObras.Add(a);
            return true;
        }

        /// <summary>
        /// Grava a lista completa de obras num ficheiro binário.
        /// </summary>
        /// <param name="caminho">O caminho ou nome do ficheiro de destino (ex: "obras.bin").</param>
        /// <returns>Retorna <c>true</c> se a gravação for bem-sucedida.</returns>
        /// <exception cref="FicheiroException">
        /// Lançada em caso de erro de acesso ao ficheiro ou falha na serialização.
        /// </exception>

        public static bool GravarFicheiro(string caminho)
        {
            try
            {
                Stream stream = File.Open(caminho, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, ListaObras);
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
