using System;
using System.Collections.Generic;
using System.Linq; // Necessário para usar .Sum()

namespace GestaoObrasLib.Modelo
{
    [Serializable] // Importante para guardar em ficheiro
    public class Orcamento : AbsOrcamento
    {
        #region Atributos (Listas Reais)

        // As listas que substituem os comentários
        private List<Material> listaMateriais;
        private List<Servico> listaServicos;
        private List<Funcionario> listaFuncionarios;

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor que inicializa as listas e define os valores iniciais a zero.
        /// </summary>
        public Orcamento(string codigo)
            : base(codigo, 0f, 0f, 0f) // Inicializamos com custo zero
        {
            listaMateriais = new List<Material>();
            listaServicos = new List<Servico>();
            listaFuncionarios = new List<Funcionario>();
        }

        #endregion

        #region Implementação dos Métodos (Overrides)

        protected override bool AdicionarMaterial(Material m)
        {
            if (m == null) return false;

            // 1. Adiciona à lista
            listaMateriais.Add(m);

            // 2. Atualiza os custos da classe base automaticamente
            this.CustoMateriais += m.Custo;

            return true;
        }

        protected override bool AdicionarServico(Servico s)
        {
            if (s == null) return false;

            listaServicos.Add(s);

            this.CustoServicos += s.Custo;
            RecalcularTotal();

            return true;
        }

        protected override bool AdicionarFuncionario(Funcionario f)
        {
            if (f == null) return false;

            listaFuncionarios.Add(f);

            // Nota: Para somar o custo de mão de obra, terias de saber as horas previstas.
            // Como o objeto Funcionario só tem Salario/Hora, aqui assumimos um valor base 
            // ou terias de mudar o método para receber (Funcionario f, int horas).
            // Exemplo simplificado (assume 1 hora apenas para registo):
            float custoEstimado = f.Salario;

            return true;
        }

        #endregion

    }
}