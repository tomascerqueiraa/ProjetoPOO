/// ============================================================================
/// Ficheiro:    Orcamento.cs
/// Projeto:     Projeto (POO - IPCA 2025/26)
/// Autor:       Tomás Afonso Cerqueira Gomes nº31501
/// Data:        2025-12-27
/// Notas:       Trabalho prático POO – Fase 2.
/// ============================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    [Serializable]
    public class Orcamento
    {
        #region Atributos
        private string codigo;
        private DateTime dataCriacao;
        private float custoMateriais;
        private float custoServicos;
        private float custoMaoDeObra;
        private float custoTotal;
        private List<Material> listaMateriais;
        private List<Servico> listaServicos;
        private List<Funcionario> listaFuncionarios;
        #endregion

        #region Propriedades

        ////// <summary>
        /// Código identificador do orçamento.
        /// </summary>
        public string Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }

        /// <summary>
        /// Data em que o orçamento foi criado.
        /// </summary>
        public DateTime DataCriacao
        {
            get { return this.dataCriacao; }
            set { this.dataCriacao = value; }
        }

        /// <summary>
        /// Custo total dos materiais incluídos no orçamento.
        /// </summary>
        public float CustoMateriais
        {
            get { return this.custoMateriais; }
            set { this.custoMateriais = value; }
        }

        /// <summary>
        /// Custo total dos serviços incluídos no orçamento.
        /// </summary>
        public float CustoServicos
        {
            get { return this.custoServicos; }
            set { this.custoServicos = value; }
        }

        /// <summary>
        /// Custo total da mão de obra incluída no orçamento.
        /// </summary>
        public float CustoMaoDeObra
        {
            get { return this.custoMaoDeObra; }
            set { this.custoMaoDeObra = value; }
        }

        /// <summary>
        /// Valor total do orçamento
        /// </summary>
        public float CustoTotal
        {
            get { return this.custoTotal; }
            set { this.custoTotal = value; }
        }

        public List<Material> ListaMateriais
        {
            get { return this.listaMateriais; }
            set { this.listaMateriais = value; }
        }

        /// <summary>
        /// Obtém ou define a lista de serviços associados à obra.
        /// </summary>
        public List<Servico> ListaServicos
        {
            get { return this.listaServicos; }
            set { this.listaServicos = value; }
        }

        /// <summary>
        /// Obtém ou define a lista de funcionários alocados à obra.
        /// </summary>
        public List<Funcionario> ListaFuncionarios
        {
            get { return this.listaFuncionarios; }
            set { this.listaFuncionarios = value; }
        }
        #endregion

        #region Construtor
        public Orcamento()
        {
            // Inicialização obrigatória das listas para evitar erros
            this.listaMateriais = new List<Material>();
            this.listaServicos = new List<Servico>();
            this.listaFuncionarios = new List<Funcionario>();
        }

        /// <summary>
        /// Construtor para criar um orçamento novo.
        /// </summary>
        /// <param name="codigo">Código único do orçamento.</param>
        /// <param name="data">Data de emissão.</param>
        public Orcamento(string codigo, DateTime data)
        {
            this.Codigo = codigo;
            this.DataCriacao = data;

            // Inicializa custos a zero
            this.CustoTotal = 0;
            this.CustoMateriais = 0;
            this.CustoServicos = 0;
            this.CustoMaoDeObra = 0;

            // Inicializa as listas
            this.listaMateriais = new List<Material>();
            this.listaServicos = new List<Servico>();
            this.listaFuncionarios = new List<Funcionario>();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Método estático para gerar um novo Orçamento.
        /// </summary>
        public static Orcamento CriarOrcamento(string codigo, DateTime data)
        {
            return new Orcamento(codigo, data);
        }
        #endregion
    }
}
