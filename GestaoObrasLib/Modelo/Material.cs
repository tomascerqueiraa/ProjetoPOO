// ============================================================================
// Ficheiro:    Material.cs
// Projeto:     Projeto (POO - IPCA 2025/26)
// Autor:       Tomás Afonso Cerqueira Gomes nº31501
// Data:        2025-11-13
// Descrição:   Classe Material.
// Notas:       Trabalho prático POO – Fase 1.
// ============================================================================

namespace GestaoObrasLib
{
    public class Material
    {
        #region Atributos
        private string nome;
        private string descricao;
        private float custo;
        #endregion

        #region Propriedades
        /// <summary>Nome do material.</summary>
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        /// <summary>Descrição do material.</summary>
        public string Descricao
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }

        /// <summary>Custo do material.</summary>
        public float Custo
        {
            get { return this.custo; }
            set { this.custo = value; }
        }

        #endregion

        #region Construtor

        /// <summary>
        /// Cria um Material com nome, descrição e custo.
        /// </summary>
        public Material(string nome, string descricao, float custo)
        {
            this.Nome = nome;
            this.descricao = descricao;
            this.custo = custo;
        }

        #endregion

        #region Métodos

        #endregion
    }
}
