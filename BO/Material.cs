using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Material
    {
        #region Atributos
        private string nome;
        private string descricao;
        private float custo;
        #endregion

        #region Propriedades
        /// <summary>Nome do material.</summary>
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        /// <summary>Descrição do material.</summary>
        public string Descricao
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }

        /// <summary>Custo do material.</summary>
        public float Custo
        {
            get { return this.custo; }
            set { this.custo = value; }
        }
        #endregion
    }
}
