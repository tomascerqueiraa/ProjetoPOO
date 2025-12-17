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
    public class Materiais
    {
        private static List<Material> listaMateriais;

        static Materiais()
        {
            listaMateriais = new List<Material>();
        }

        // Adicionar um novo material ao catálogo da empresa
        public static bool AdicionarMaterial(Material m)
        {
            if (m == null) return false;
            // Podes verificar se já existe um material com o mesmo nome
            listaMateriais.Add(m);
            return true;
        }

        // Gravar o catálogo em ficheiro (ex: "stocks.bin")
        public static bool  GravarFicheiro(string caminho)
        {
            try
            {
                Stream stream = File.Open(caminho, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, listaMateriais);
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
