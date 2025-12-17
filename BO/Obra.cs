using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    [Serializable]
    public class Obra:AbsObra
    {
        #region Atributos
        private List<Material> listaMateriais;
        private List<Servico> listaServicos;
        private List<Funcionario> listaFuncionarios;
        private List<Orcamento> listaOrcamentos;
        #endregion

        #region Propriedades

        #endregion
    }
}
