/// ============================================================================
/// Ficheiro:    Orcamentos.cs
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
    /// Classe responsável pela gestão e persistência da coleção de Orçamentos.
    /// Gere a lista de orçamentos emitidos pela empresa e permite a sua gravação em ficheiro.
    /// </summary>
    [Serializable]
    public class Orcamentos
    {
        private static List<Orcamento> listaOrcamentos;

        #region Construtores
        /// <summary>
        /// Construtor estático da classe Orcamentos.
        /// Inicializa a lista de orçamentos para garantir que não está nula ao arrancar.
        /// </summary>
        static Orcamentos()
        {
            listaOrcamentos = new List<Orcamento>();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Adiciona um novo orçamento à lista de registos da empresa.
        /// </summary>
        /// <param name="o">Objeto do tipo Orcamento a ser inserido.</param>
        /// <returns>
        /// Retorna <c>true</c> se o orçamento for inserido com sucesso;
        /// Retorna <c>false</c> se o objeto fornecido for nulo.
        /// </returns>
        // Adicionar um orçamento
        public static bool AdicionarOrcamento(Orcamento o)
        {
            if (o == null) return false;

            listaOrcamentos.Add(o);
            return true;
        }

        /// <summary>
        /// Grava a lista completa de orçamentos num ficheiro binário.
        /// </summary>
        /// <param name="caminho">Caminho ou nome do ficheiro de destino (ex: "orcamentos.bin").</param>
        /// <returns>Retorna <c>true</c> em caso de sucesso.</returns>
        /// <exception cref="FicheiroException">
        /// Lançada quando ocorrem erros de I/O (escrita) ou de serialização.
        /// A exceção original é preservada dentro desta exceção personalizada.
        /// </exception>
        public static bool GravarFicheiro(string caminho)
        {
            try
            {
                Stream stream = File.Open(caminho, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, listaOrcamentos);
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
