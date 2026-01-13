/// ============================================================================
/// Ficheiro:    Servicos.cs
/// Projeto:     Projeto (POO - IPCA 2025/26)
/// Autor:       Tomás Afonso Cerqueira Gomes nº31501
/// Data:        2025-12-27
/// Notas:       Trabalho prático POO – Fase 2.
/// ============================================================================


using BO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Exceptions;

namespace Dados
{
    /// <summary>
    /// Classe responsável pela gestão e armazenamento dos dados referentes aos Serviços.
    /// Utiliza uma lista estática para manter os dados em memória e métodos para persistência em ficheiro.
    /// </summary>
    [Serializable]
    public class Servicos
    {
        private List<Servico> listaServicos;

        #region Construtores
        /// <summary>
        /// Construtor estático da classe Servicos.
        /// Inicializa a lista de serviços antes de qualquer membro estático ser acedido.
        /// </summary>
        public Servicos()
        {
            listaServicos = new List<Servico>();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Adiciona um novo serviço ao catálogo da empresa.
        /// </summary>
        /// <param name="s">Objeto do tipo Servico a ser adicionado.</param>
        /// <returns>
        /// Retorna <c>true</c> se o serviço for adicionado com sucesso; 
        /// Retorna <c>false</c> se o serviço fornecido for nulo.
        /// </returns>
        public bool AdicionarServico(Servico s)
        {
            if (s == null) return false;
            listaServicos.Add(s);
            return true;
        }

        /// <summary>
        /// Grava a lista atual de serviços num ficheiro binário para persistência de dados.
        /// </summary>
        /// <param name="caminho">O caminho (path) ou nome do ficheiro onde os dados serão guardados.</param>
        /// <returns>Retorna <c>true</c> se a gravação for bem-sucedida.</returns>
        /// <exception cref="FicheiroException">Lançada caso ocorra um erro de I/O ou serialização durante a gravação.</exception>
        public bool GravarFicheiro(string caminho)
        {
            try
            {
                Stream stream = File.Open(caminho, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, listaServicos);
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
