using System;
using BO;
using Dados;

namespace Regras
{
    public static class RegrasObras
    {
        /// <summary>
        /// Valida e insere uma nova obra no sistema.
        /// </summary>
        public static bool NovaObra(Obra o)
        {
            if (o == null) return false;

            // Regra 1: Nome da obra é obrigatório
            if (string.IsNullOrEmpty(o.Nome))
            {
                throw new Exception("ERRO: A obra tem de ter um nome ou identificação.");
            }

            // Regra 2: Localização é obrigatória
            if (string.IsNullOrEmpty(o.Localizacao))
            {
                throw new Exception("ERRO: Indique a localização da obra.");
            }

            // Regra 3: A data de fim não pode ser anterior à data de início
            if (o.DataFimPrevisto < o.DataInicio)
            {
                throw new Exception("ERRO: A data de conclusão prevista não pode ser anterior à data de início.");
            }

            // Chama a camada Dados para inserir (Obras.cs deve ter método static)
            return Obras.InsereObra(o);
        }

        public static bool Gravar(string caminho)
        {
            return Obras.GravarFicheiro(caminho);
        }
    }
}