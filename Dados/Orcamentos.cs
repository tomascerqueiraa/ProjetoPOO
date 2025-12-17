using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using BO;

namespace Dados
{
    [Serializable]
    public class Orcamentos
    {
        private static List<Orcamento> listaOrcamentos;

        static Orcamentos()
        {
            listaOrcamentos = new List<Orcamento>();
        }

        // Adicionar um orçamento
        public static bool AdicionarOrcamento(Orcamento o)
        {
            if (o == null) return false;

            listaOrcamentos.Add(o);
            return true;
        }

        // Gravar ficheiro
        public static bool GravarFicheiro(string caminho)
        {
            try
            {
                Stream stream = File.Open(caminho, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, listaOrcamentos);
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
