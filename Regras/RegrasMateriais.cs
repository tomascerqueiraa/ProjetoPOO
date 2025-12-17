
using BO;
using Dados;

namespace Regras
{
    public class RegrasMateriais
    {
        public static bool InserirMaterial(Material m)
        {
            // 1. Validações (Regras de Negócio)
            if (m == null) return false;

            // 2. Chama diretamente o método estático da camada Dados
            bool suc = Materiais.AdicionarMaterial(m);
            return suc;
        }
        public static bool Gravar(string caminho)
        {
            // Valida se o caminho é válido antes de mandar gravar
            if (string.IsNullOrEmpty(caminho)) return false;

            return Materiais.GravarFicheiro(caminho);
        }
    }
}
