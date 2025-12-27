/// ============================================================================
/// Ficheiro:    Fornecedor.cs
/// Projeto:     Projeto (POO - IPCA 2025/26)
/// Autor:       Tomás Afonso Cerqueira Gomes nº31501
/// Data:        2025-12-27
/// Notas:       Trabalho prático POO – Fase 2.
/// ============================================================================


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Fornecedor
    {
        #region Atributos
        private string nome;
        private string descricao;
        private string contacto;
        #endregion

        #region Propriedades
        /// <summary>
        /// Obtém ou define o Nome.
        /// </summary>
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        /// <summary>
        /// Obtém ou define a descrição.
        /// </summary>
        public string Descricao
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }
        /// <summary>
        /// Obtém ou define o Contacto.
        /// </summary>
        public string Contacto
        {
            get { return this.contacto; }
            set { this.contacto = value; }
        }
        #endregion

        #region Construtor

        /// <summary>
        /// Construtor completo.
        /// </summary>
        public Fornecedor(string nome, string contacto, string descricao)
        {
            this.Nome = nome;
            this.Contacto = contacto; // Se a tua propriedade ainda for 'Contato', muda aqui
            this.Descricao = descricao;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Método estático para criar um novo Fornecedor.
        /// </summary>
        public static Fornecedor CriarFornecedor(string nome, string contacto, string descricao)
        {
            Fornecedor novoForn = new Fornecedor(nome, contacto, descricao);
            return novoForn;
        }
        #endregion
    }
}
