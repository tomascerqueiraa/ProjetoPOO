using BO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    [Serializable]
    public class Servicos
    {
        private static List<Servico> listaServicos;

        static Servicos()
        {
            listaServicos = new List<Servico>();
        }

        // Adicionar um novo serviço ao catálogo
        public static bool AdicionarServico(Servico s)
        {
            if (s == null) return false;
            // Opcional: Verificar se já existe serviço com o mesmo nome
            listaServicos.Add(s);
            return true;
        }

        // Gravar ficheiro
        public static bool GravarFicheiro(string caminho)
        {
            try
            {
                Stream stream = File.Open(caminho, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, listaServicos);
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
