using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace Dados
{
    [Serializable]
    public class Funcionarios
    {
        private static List<Funcionario> listaFuncionarios;

        static Funcionarios()
        {
            listaFuncionarios = new List<Funcionario>();
        }

        // Adicionar um novo funcionário
        public static bool AdicionarFuncionario(Funcionario f)
        {
            if (f == null) return false;

            listaFuncionarios.Add(f);
            return true;
        }

        // Gravar a lista de funcionários em ficheiro
        public static bool GravarFicheiro(string caminho)
        {
            try
            {
                Stream stream = File.Open(caminho, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, listaFuncionarios);
                stream.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
