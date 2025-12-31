/// ============================================================================
/// Ficheiro:    Material.cs
/// Projeto:     Projeto (POO - IPCA 2025/26)
/// Autor:       Tomás Afonso Cerqueira Gomes nº31501
/// Data:        2025-12-27
/// Notas:       Trabalho prático POO – Fase 2.
/// ============================================================================


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    [Serializable]
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
        /// Construtor completo.
        /// </summary>
        public Material(string nome, string descricao, float custo)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.Custo = custo;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Método estático para criar um novo Material validado.
        /// </summary>
        public static Material CriarMaterial(string nome, string descricao, float custo)
        {
            return new Material(nome, descricao, custo);
        }
        #endregion
    }
}
