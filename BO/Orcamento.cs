using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Orcamento
    {
        #region Atributos
        private string codigo;
        private DateTime dataCriacao;
        private float custoMateriais;
        private float custoServicos;
        private float custoMaoDeObra;
        private float custoTotal;
        public List<Material> listaMateriais;
        public List<Servico> listaServicos;
        public List<Funcionario> listaFuncionarios;
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
        #endregion
    
    }
}
