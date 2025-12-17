using BO;    // Referência aos Objetos
using Dados; // Referência à camada de Dados

namespace Regras
{
    public static class RegrasFornecedores
    {
        /// <summary>
        /// Valida e insere um novo fornecedor.
        /// </summary>
        public static bool InserirFornecedor(Fornecedor f)
        {
            // 1. Validações de entrada
            if (f == null) return false;

            // 2. Se tudo estiver bem, chama a camada de Dados (Método Estático)
            return Fornecedores.AdicionarFornecedor(f);
        }

        /// <summary>
        /// Grava a lista de fornecedores em ficheiro.
        /// </summary>
        public static bool Gravar(string caminho)
        {
            if (string.IsNullOrEmpty(caminho)) return false;
            return Fornecedores.GravarFicheiro(caminho);
        }
    }
}