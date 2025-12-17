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
    }
}
