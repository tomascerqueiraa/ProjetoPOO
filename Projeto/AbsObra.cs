// ============================================================================
// Ficheiro:    AbsObra.cs
// Projeto:     Projeto (POO - IPCA 2025/26)
// Autor:       Tomás Afonso Cerqueira Gomes nº31501
// Data:        2025-11-13
// Descrição:   Modelo abstrato de uma Obra.
// Notas:       Trabalho prático POO – Fase 1.
// ============================================================================

using System;

namespace Projeto
{
    /// <summary>
    /// Classe abstrata que representa uma obra de construção civil.
    /// Contém os dados básicos de uma obra e métodos abstratos para adicionar materiais,
    /// serviços e funcionários a uma obra.
    /// </summary>
    public abstract class AbsObra
    {
        #region Atributos
        private string nome;
        private string localizacao;
        private DateTime dataInicio;
        private DateTime dataFimPrevisto;
        //funcionarios;
        //materiais;
        //servicos;
        //orçamentos
        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o nome da obra.
        /// </summary>
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        /// <summary>
        /// Obtém ou define a localização da obra.
        /// </summary>
        public string Localizacao
        {
            get { return this.localizacao; }
            set { this.localizacao = value; }
        }

        /// <summary>
        /// Obtém ou define a data de início da obra.
        /// </summary>
        public DateTime DataInicio
        {
            get { return this.dataInicio; }
            set { this.dataInicio = value; }
        }

        /// <summary>
        /// Obtém ou define a data prevista de término da obra.
        /// </summary>
        public DateTime DataFimPrevisto
        {
            get { return this.dataFimPrevisto; }
            set { this.dataFimPrevisto = value; }
        }

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe "AbsObra para inicializar os dados da obra.
        /// </summary>
        protected AbsObra(string nome, string localizacao, DateTime dataInicio, DateTime dataFimPrevisto)
        {
            this.nome = nome;
            this.localizacao = localizacao;
            this.dataInicio = dataInicio;
            this.dataFimPrevisto = dataFimPrevisto;
        }
        #endregion

        #region Métodos
        // Método para adicionar um material à obra
        protected abstract bool AdicionarMaterial();

        protected abstract bool AdicionarServico();

        // Método para adicionar um funcionário à obra
        protected abstract bool AdicionarFuncionario();

        #endregion
    }
}
