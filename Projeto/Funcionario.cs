// ============================================================================
// Ficheiro:    Funcionario.cs
// Projeto:     Projeto (POO - IPCA 2025/26)
// Autor:       Tomás Afonso Cerqueira Gomes nº31501
// Data:        2025-11-13
// Descrição:   Classe Funcionario.
// Notas:       Trabalho prático POO – Fase 1.
// ============================================================================


namespace Projeto
{
    public class Funcionario
    {
        #region Atributos
        private string nomeF;
        private string funcao;
        private float salario;
        #endregion

        #region Propriedades

        /// <summary>Nome do funcionário.</summary>
        public string NomeF
        {
            get { return this.nomeF; }
            set { this.nomeF = value; }
        }

        /// <summary>Função ou cargo do funcionário.</summary>
        public string Funcao
        {
            get { return this.funcao; }
            set { this.funcao = value; }
        }

        /// <summary>Salário do funcionário por hora.</summary>
        public float Salario
        {
            get { return this.salario; }
            set { this.salario = value; }
        }
        #endregion

        #region Construtor
        /// <summary>
        /// Cria um Funcionario com nome, função e salário.
        /// </summary>
        public Funcionario(string nomeF, string funcao, float salario)
        {
            this.nomeF = nomeF;
            this.funcao = funcao;
            this.salario = salario;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Calcula o salário total do funcionário com base no número de horas trabalhadas.
        /// </summary>
        public float CalcularSalario(int horasTrabalhadas)
        {
            return this.salario * horasTrabalhadas;
        }
        #endregion


    }
}
