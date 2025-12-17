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
    public class Obras
    {
        static List<Obra> ListaObras;

        static Obras()
        {
            ListaObras = new List<Obra>();
        }

        public static bool InsereObra(Obra a)
        {
            if (ListaObras.Contains(a)) return false;
            ListaObras.Add(a);
            return true;
        }

        public static bool GravarFicheiro(string caminho)
        {
            try
            {
                Stream stream = File.Open(caminho, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, ListaObras);
                stream.Close();
                return true;
            }
            catch (Exception)
            {
                return false; // Ou lançar exceção customizada
            }
        }

    }
}
