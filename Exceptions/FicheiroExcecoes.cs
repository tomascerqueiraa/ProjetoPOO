/// ============================================================================
/// Ficheiro:    FicheiroExcecoes.cs
/// Projeto:     Projeto (POO - IPCA 2025/26)
/// Autor:       Tomás Afonso Cerqueira Gomes nº31501
/// Data:        2025-12-27
/// Notas:       Trabalho prático POO – Fase 2.
/// ============================================================================

using System;

namespace Exceptions
{
    /// <summary>
    /// Exceção personalizada para tratar erros específicos de operações com ficheiros.
    /// Herda de ApplicationException para distinguir erros de negócio de erros de sistema (SystemException).
    /// </summary>
    public class FicheiroExcecoes : Exception
    {
        public class FicheiroException : ApplicationException
        {
            /// <summary>
            /// Construtor vazio. Inicializa a exceção com uma mensagem genérica padrão.
            /// </summary>
            public FicheiroException() : base("Erro genérico de ficheiros...")
            {
            }

            /// <summary>
            /// Construtor que aceita uma mensagem de erro personalizada.
            /// </summary>
            /// <param name="msg">A mensagem que descreve o erro.</param> 
            public FicheiroException(string msg) : base(msg)
            {
            }

            /// <summary>
            /// Construtor completo que aceita uma mensagem e a exceção original (InnerException).
            /// Fundamental para não perder a causa real do erro (ex: disco cheio, sem permissões).
            /// </summary>
            /// <param name="msg">A mensagem personalizada do erro.</param>
            /// <param name="e">A exceção original que causou este erro.</param>
            public FicheiroException(string msg, Exception e)
            {
            }
        }
    }
}
