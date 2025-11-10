// ============================================================================
// Ficheiro:    Fornecedor.cs
// Projeto:     Projeto (POO - IPCA 2025/26)
// Autor:       Tomás Afonso Cerqueira Gomes nº31501
// Data:        2025-11-13
// Descrição:   Classe Funcionario.
// Notas:       Trabalho prático POO – Fase 1.
// ============================================================================

using System;

namespace Projeto
{
    public class Fornecedor
    {
        
        
        #region Atributos
        private string nome;
        private string descricao;
        private string contato;
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
        public string Contato 
        { 
            get { return this.contato; } 
            set { this.contato = value; } 
        }
        #endregion

        #region Construtores
        /// <summary>
        /// Construtor que inicializa uma nova instância de Fornecedor com nome, tipo e contato.
        /// </summary>
        public Fornecedor(string nome, string descricao, string contato)
        {
            this.nome = nome;
            this.descricao = descricao;
            this.contato = contato;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Método para exibir as informações do fornecedor.
        /// </summary>
        public void MostrarInfo()
        {
            Console.WriteLine($"Fornecedor: {this.nome}");
            Console.WriteLine($"Tipo: {this.descricao}");
            Console.WriteLine($"Contato: {this.contato}");
        }
        #endregion
    
    }
}
