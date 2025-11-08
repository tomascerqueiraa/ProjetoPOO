// ============================================================================
// Ficheiro:    AbsOrcamento.cs
// Projeto:     Projeto (POO - IPCA 2025/26)
// Autor:       Tomás Afonso Cerqueira Gomes nº31501
// Data:        2025-11-13
// Descrição:   Classe AbsOrcamento.
// Notas:       Trabalho prático POO – Fase 1.
// ============================================================================

using System;

namespace Projeto
{
    public abstract class AbsOrcamento
    {
        #region Atributos
        private string codigo;
        private DateTime dataCriacao;
        private float custoMateriais;
        private float custoServicos;
        private float custoMaoDeObra;
        private float custoTotal;
        //materiais;
        //servicos;
        //funcionarios;
        #endregion

        #region Propriedades
        ///Código identificador do orçamento.
        public string Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }

        //Data em que o orçamento foi criado.
        public DateTime DataCriacao
        {
            get { return this.dataCriacao; }
            set { this.dataCriacao = value; }
        }

        //Custo total dos materiais incluídos no orçamento.
        public float CustoMateriais
        {
            get { return this.custoMateriais; }
            set { this.custoMateriais = value; }
        }

        //Custo total dos serviços incluídos no orçamento.
        public float CustoServicos
        {
            get { return this.custoServicos; }
            set { this.custoServicos = value; }
        }

        //Custo total da mão de obra incluída no orçamento.
        public float CustoMaoDeObra
        {
            get { return this.custoMaoDeObra; }
            set { this.custoMaoDeObra = value; }
        }

        //Valor total do orçamento
        public float CustoTotal
        {
            get { return this.custoTotal; }
            set { this.custoTotal = value; }
        }
        #endregion

        #region Construtor
        /// <summary>
        /// Cria um Orçamento com codigo, custo dos materiais, custo de serviços, custo de mão de obra e o custo total.
        /// </summary>
        protected AbsOrcamento(string codigo, float custoMateriais, float custoServicos, float custoMaoDeObra)
        {
            this.codigo = codigo;
            this.dataCriacao = DateTime.Now;

            this.custoMateriais = custoMateriais;
            this.custoServicos = custoServicos;
            this.custoMaoDeObra = custoMaoDeObra;
            this.custoTotal = custoMaoDeObra + custoServicos + custoMateriais;
        }
        #endregion

        #region Métodos
        // para os atributos comentados
        protected abstract bool AdicionarMaterial(/*Material material*/);
        protected abstract bool AdicionarServico(/*Servico servico*/);
        protected abstract bool AdicionarFuncionario(/*Funcionario funcionario*/);
        #endregion
    }
}
