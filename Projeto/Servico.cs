// ============================================================================
// Ficheiro:    Servico.cs
// Projeto:     Projeto (POO - IPCA 2025/26)
// Autor:       Tomás Afonso Cerqueira Gomes nº31501
// Data:        2025-11-13
// Descrição:   Classe Servico.
// Notas:       Trabalho prático POO – Fase 1.
// ============================================================================

namespace Projeto
{
    public class Servico
    {
        #region Atributos
        private string nome;
        private string descricao;
        private float custo;
        #endregion

        #region Propriedades

        /// <summary>Nome do serviço.</summary>
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        /// <summary>Descrição do serviço.</summary>
        public string Descricao
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }

        /// <summary>Custo do serviço.</summary>
        public float Custo
        {
            get { return this.custo; }
            set { this.custo = value; }
        }

        #endregion

        #region Construtor

        /// <summary>
        /// Cria um Servico com nome, descrição e custo.
        /// </summary>
        public Servico(string nome, string descricao, float custo)
        {
            this.nome = nome;
            this.descricao = descricao;
            this.custo = custo;
        }

        #endregion

        #region Métodos

        #endregion
    }
}
