using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public class Funcionario
    {
        public string NomeF;
        public string Funcao;
        public float Salario; //por hora

        #region Construtor
        public Funcionario(string nome, string funcao, float salario)
        {
            NomeF = nome;
            Funcao = funcao;
            Salario = salario;
        }
        #endregion

        #region Métodos
        public double CalcularSalario(int horasTrabalhadas)
        {
            return Salario * horasTrabalhadas;
        }
        #endregion


    }
}
