/// ============================================================================
/// Ficheiro:    Funcionario.cs
/// Projeto:     Projeto (POO - IPCA 2025/26)
/// Autor:       Tomás Afonso Cerqueira Gomes nº31501
/// Data:        2025-12-27
/// Notas:       Trabalho prático POO – Fase 2.
/// ============================================================================


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
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
        /// Construtor com parâmetros para inicializar o funcionário.
        /// </summary>
        public Funcionario(string nome, string funcao, float salario)
        {
            this.NomeF = nome;
            this.Funcao = funcao;
            this.Salario = salario;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Método estático para criar um novo Funcionário de forma rápida.
        /// </summary>
        public static Funcionario CriarFuncionario(string nome, string funcao, float salario)
        {
            // Cria a instância usando o construtor acima
            Funcionario novoFunc = new Funcionario(nome, funcao, salario);
            return novoFunc;
        }
        #endregion
    }
}
