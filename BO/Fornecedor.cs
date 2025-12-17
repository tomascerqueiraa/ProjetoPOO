using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Fornecedor
    {
        #region Atributos
        private string nome;
        private string descricao;
        private string contacto;
        #endregion

        #region Propriedades
        /// <summary>
        /// Obtém ou define o Nome.
        /// </summary>
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        /// <summary>
        /// Obtém ou define a descrição.
        /// </summary>
        public string Descricao
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }
        /// <summary>
        /// Obtém ou define o Contacto.
        /// </summary>
        public string Contato
        {
            get { return this.contacto; }
            set { this.contacto = value; }
        }
        #endregion
    }
}
