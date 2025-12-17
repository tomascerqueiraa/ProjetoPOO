using BO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Dados
{
    [Serializable]
    public class Fornecedores
    {
        // Lista estática para manter os dados partilhados por toda a aplicação
        private static List<Fornecedor> listaFornecedores;

        // Construtor estático: corre apenas uma vez para inicializar a lista
        static Fornecedores()
        {
            listaFornecedores = new List<Fornecedor>();
        }

        // Adicionar um novo fornecedor
        public static bool AdicionarFornecedor(Fornecedor f)
        {
            if (f == null) return false;
            // Podes adicionar validação para não repetir NIF ou Nome
            if (listaFornecedores.Contains(f)) return false;

            listaFornecedores.Add(f);
            return true;
        }

        // Gravar a lista de fornecedores em ficheiro
        public static bool GravarFicheiro(string caminho)
        {
            try
            {
                Stream stream = File.Open(caminho, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();

                // Serializamos a lista estática diretamente
                bin.Serialize(stream, listaFornecedores);

                stream.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /*
        // Adicionei este método pois vais precisar de carregar os dados quando o programa abre
        public bool LerFicheiro(string caminho)
        {
            try
            {
                if (!File.Exists(caminho)) return false;

                Stream stream = File.Open(caminho, FileMode.Open);
                BinaryFormatter bin = new BinaryFormatter();

                // Deserializamos para a lista estática
                listaFornecedores = (List<Fornecedor>)bin.Deserialize(stream);

                stream.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Método auxiliar para obteres a lista se precisares de a mostrar na UI
        public List<Fornecedor> ObterLista()
        {
            return new List<Fornecedor>(listaFornecedores);
        }*/
    }
}