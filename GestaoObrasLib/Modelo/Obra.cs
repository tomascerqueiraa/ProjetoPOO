using System;
using System.Collections.Generic;
using System.Linq;

namespace GestaoObrasLib
{
    /// <summary>
    /// Classe concreta que representa uma Obra real.
    /// Herda de AbsObra e implementa a gestão de listas (materiais, serviços, etc).
    /// </summary>
    [Serializable] // Importante para a Fase 2 (Guardar em ficheiro)
    public class Obra : AbsObra
    {
        #region Atributos (Coleções)

        // Substituição dos comentários por Listas reais
        private List<Material> listaMateriais;
        private List<Servico> listaServicos;
        private List<Funcionario> listaFuncionarios;
        private List<AbsOrcamento> listaOrcamentos;

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da Obra. Inicializa as listas vazias.
        /// </summary>
        public Obra(string nome, string localizacao, DateTime dataInicio, DateTime dataFimPrevisto)
            : base(nome, localizacao, dataInicio, dataFimPrevisto)
        {
            // É fundamental inicializar as listas no construtor para evitar "NullReferenceException"
            this.listaMateriais = new List<Material>();
            this.listaServicos = new List<Servico>();
            this.listaFuncionarios = new List<Funcionario>();
            this.listaOrcamentos = new List<AbsOrcamento>();
        }

        #endregion

        #region Métodos Implementados (Overrides)

        /// <summary>
        /// Adiciona um material à lista da obra.
        /// </summary>
        protected override bool AdicionarMaterial(Material m)
        {
            // Validações (Regra de Negócio)
            if (m == null) return false;

            // Adiciona à lista
            listaMateriais.Add(m);
            return true;
        }

        /// <summary>
        /// Adiciona um serviço à lista da obra.
        /// </summary>
        protected override bool AdicionarServico(Servico s)
        {
            if (s == null) return false;
            listaServicos.Add(s);
            return true;
        }

        /// <summary>
        /// Adiciona um funcionário à lista da obra.
        /// </summary>
        protected override bool AdicionarFuncionario(Funcionario f)
        {
            if (f == null) return false;

            // Exemplo de validação: Não adicionar funcionários duplicados
            if (listaFuncionarios.Contains(f)) return false;

            listaFuncionarios.Add(f);
            return true;
        }

        /// <summary>
        /// Implementação obrigatória para adicionar orçamentos à obra.
        /// </summary>
        protected override bool AdicionarOrcamento(AbsOrcamento o)
        {
            // 1. Validação básica
            if (o == null) return false;

            // 2. Adiciona à lista
            listaOrcamentos.Add(o);

            return true;
        }

        #endregion

        #region Métodos Extras (Valorização)

        /// <summary>
        /// Calcula o custo total atual da obra somando materiais e serviços.
        /// </summary>
        public float CalcularCustoTotal()
        {
            float totalMateriais = listaMateriais.Sum(m => m.Custo);
            float totalServicos = listaServicos.Sum(s => s.Custo);
            // float totalMaoDeObra = ... (depende da tua lógica de Funcionário)

            return totalMateriais + totalServicos;
        }
        #endregion
    }
}