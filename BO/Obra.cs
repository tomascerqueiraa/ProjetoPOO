/// ============================================================================
/// Ficheiro:    Obra.cs
/// Projeto:     Projeto (POO - IPCA 2025/26)
/// Autor:       Tomás Afonso Cerqueira Gomes nº31501
/// Data:        2025-12-27
/// Notas:       Trabalho prático POO – Fase 2.
/// ============================================================================

using System;
using System.Collections.Generic;
using System.Linq;

namespace BO
{
    [Serializable]
    public class Obra:AbsObra
    {
        #region Atributos
        private List<Material> listaMateriais;
        private List<Servico> listaServicos;
        private List<Funcionario> listaFuncionarios;
        private List<Orcamento> listaOrcamentos;
        #endregion

        #region Propriedades
        /// <summary>
        /// Obtém ou define a lista de materiais associados à obra.
        /// </summary>
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

        /// <summary>
        /// Obtém ou define a lista de orçamentos da obra.
        /// </summary>
        public List<Orcamento> ListaOrcamentos
        {
            get { return this.listaOrcamentos; }
            set { this.listaOrcamentos = value; }
        }
        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da Obra. Inicializa as listas vazias.
        /// </summary>
        public Obra(string nome, string localizacao, DateTime dataInicio, DateTime dataFimPrevisto)
            : base(nome, localizacao, dataInicio, dataFimPrevisto)
        {
            this.listaMateriais = new List<Material>();
            this.listaServicos = new List<Servico>();
            this.listaFuncionarios = new List<Funcionario>();
            this.listaOrcamentos = new List<Orcamento>();
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método para criar uma nova obra com os dados essenciais.
        /// Isto ajuda a garantir que ninguém cria uma obra sem nome ou local.
        /// </summary>
        /// <param name="nome">Designação da obra.</param>
        /// <param name="local">Localização da obra.</param>
        /// <param name="inicio">Data de início.</param>
        /// <param name="fim">Data prevista de conclusão.</param>
        /// <returns>Uma nova instância da classe Obra devidamente preenchida.</returns>
        public Obra CriarObra(string nome, string local, DateTime inicio, DateTime fim)
        {
            Obra novaObra = new Obra(nome, local, inicio, fim);

            return novaObra;
        }

        // Adicionar Material
        public override bool AdicionarMaterial(Material m)
        {
            if (m == null) return false;
            // Valida se a lista foi inicializada
            if (this.ListaMateriais == null) this.ListaMateriais = new List<Material>();

            this.ListaMateriais.Add(m);
            return true;
        }

        // Adicionar Serviço
        public override bool AdicionarServico(Servico s)
        {
            if (s == null) return false;
            if (this.ListaServicos == null) this.ListaServicos = new List<Servico>();

            this.ListaServicos.Add(s);
            return true;
        }

        // Adicionar Funcionário
        public override bool AdicionarFuncionario(Funcionario f)
        {
            if (f == null) return false;
            if (this.ListaFuncionarios == null) this.ListaFuncionarios = new List<Funcionario>();

            this.ListaFuncionarios.Add(f);
            return true;
        }

        // Calcular Custo Total
        public double CalcularCustoTotal()
        {
            double total = 0;

            // Soma os Materiais
            if (ListaMateriais != null)
                total += ListaMateriais.Sum(m => m.Custo);

            // Soma os Serviços
            if (ListaServicos != null)
                total += ListaServicos.Sum(s => s.Custo);

            // Soma os Funcionários (Salário)
            if (ListaFuncionarios != null)
                total += ListaFuncionarios.Sum(f => f.Salario);

            return total;
        }

        #endregion
    }
}
