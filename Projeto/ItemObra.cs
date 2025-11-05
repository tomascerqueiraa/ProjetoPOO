using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public class ItemObra
    {
        public string Nome;
        public string Descricao;
        public double Custo;

        #region Construtor

        #endregion

        #region Métodos
        public ItemObra(string nome, string descricao, double custo)
        {
            Nome = nome;
            Descricao = descricao;
            Custo = custo;
        }
        #endregion
    }
}
