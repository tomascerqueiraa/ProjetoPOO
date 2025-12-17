using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using Dados;

namespace Regras
{
    public static class RegrasFuncionarios
    {
        /// <summary>
        /// Valida e regista um novo funcionário.
        /// </summary>
        public static bool RegistarFuncionario(Funcionario f)
        {
            // 1. Validações
            if (f == null) return false;

            // Regra: Nome obrigatório
            if (string.IsNullOrEmpty(f.NomeF))
            {
                throw new Exception("ERRO: O funcionário tem de ter um nome.");
            }

            // Regra: Deve ter uma função/cargo atribuído
            if (string.IsNullOrEmpty(f.Funcao))
            {
                throw new Exception("ERRO: É necessário definir a função do funcionário.");
            }

            // Regra: O salário não pode ser negativo ou zero
            if (f.Salario <= 0)
            {
                throw new Exception("ERRO: O salário deve ser um valor positivo.");
            }

            // 2. Chama a camada de Dados (Método Estático)
            return Funcionarios.AdicionarFuncionario(f);
        }

        /// <summary>
        /// Grava a lista de funcionários.
        /// </summary>
        public static bool Gravar(string caminho)
        {
            return Funcionarios.GravarFicheiro(caminho);
        }
    }
}