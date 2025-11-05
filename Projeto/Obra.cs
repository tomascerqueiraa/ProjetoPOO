using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public class Obra
    {
        public string nome;
        public string localizacao;
        public DateTime dataInicio;
        public DateTime dataFimPrevisto;
        public List<Funcionario> funcionarios;
        public List<Material> materiais;
        public List<Servico> servicos;
        //orçamentos

        #region Construtor
        public Obra(string nome, string localizacao, DateTime dataInicio, DateTime dataFimPrevisto)
        {
            this.nome = nome;  // "this" refere-se ao atributo da classe
            this.localizacao = localizacao;  // Atribuindo o valor ao atributo da classe
            this.dataInicio = dataInicio;
            this.dataFimPrevisto = dataFimPrevisto;
            materiais = new List<Material>();  // Inicializando a lista de materiais
            servicos = new List<Servico>();  // Inicializando a lista de serviços
            funcionarios = new List<Funcionario>();  // Inicializando a lista de funcionários
        }
        #endregion

        #region Métodos
        // Método para adicionar um material à obra
        public bool AdicionarMaterial(Material material)
        {
            if (material != null) // Verifica se o material é válido
            {
                materiais.Add(material);
                return true; // Retorna true se o material foi adicionado com sucesso
            }
            return false; // Retorna false se o material for nulo ou inválido
        }

        public bool AdicionarServico(Servico servico)
        {
            if (servico != null) // Verifica se o serviço é válido
            {
                servicos.Add(servico);
                return true; // Retorna true se o serviço foi adicionado com sucesso
            }
            return false; // Retorna false se o serviço for nulo ou inválido
        }

        // Método para adicionar um funcionário à obra
        public bool AdicionarFuncionario(Funcionario funcionario)
        {
            if (funcionario != null) // Verifica se o funcionário é válido
            {
                funcionarios.Add(funcionario);
                return true; // Retorna true se o funcionário foi adicionado com sucesso
            }
            return false; // Retorna false se o funcionário for nulo ou inválido
        }


        #endregion
    }
}
