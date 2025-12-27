/// ============================================================================
/// Ficheiro:    AbsObra.cs
/// Projeto:     Projeto (POO - IPCA 2025/26)
/// Autor:       Tomás Afonso Cerqueira Gomes nº31501
/// Data:        2025-12-27
/// Notas:       Trabalho prático POO – Fase 2.
/// ============================================================================

using System;

namespace BO
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
        /// Construtor da classe AbsObra.
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
        
        /// <summary>
        /// Método que irá adicionar um material à obra
        /// </summary>
        public abstract bool AdicionarMaterial(Material m);

        /// <summary>
        /// Método que irá adicionar um serviço à obra
        /// </summary>
        public abstract bool AdicionarServico(Servico s);

        /// <summary>
        /// Método que irá adicionar um funcionário à obra
        /// </summary>
        public abstract bool AdicionarFuncionario(Funcionario f);

        /// <summary>
        ///  Método que irá adicionar um orcamento à obra
        /// </summary>
        //protected abstract bool AdicionarOrcamento(AbsOrcamento o);
        
        #endregion
    }
}
