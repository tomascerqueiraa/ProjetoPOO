/// ============================================================================
/// Ficheiro:    Program.cs
/// Projeto:     Projeto (POO - IPCA 2025/26)
/// Autor:       Tomás Afonso Cerqueira Gomes nº31501
/// Data:        2025-11-13
/// Notas:       Trabalho prático POO – Fase 2.
/// ============================================================================
using System;
using BO;
using Regras;
using Exceptions;

namespace GestaoObraApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================================");
            Console.WriteLine("   DEMONSTRAÇÃO DO PROJETO DE GESTÃO DE OBRAS    ");
            Console.WriteLine("=================================================");

            try
            {
                // -----------------------------------------------------------
                // 1. CRIAR DADOS
                // -----------------------------------------------------------
                Console.WriteLine("\n[1] A Inicializar Catálogos (Materiais e Funcionários)...");

                // Criar alguns materiais
                Material mat1 = Material.CriarMaterial("Cimento", "Saco 25kg", 5.50f);
                Material mat2 = Material.CriarMaterial("Tijolo", "Bloco térmico", 0.80f);
                Material mat3 = Material.CriarMaterial("Areia", "Metro Cúbico", 15.0f);

                // Inserir no sistema (Regras valida e manda para Dados)
                RegrasMateriais.InserirMaterial(mat1);
                RegrasMateriais.InserirMaterial(mat2);
                RegrasMateriais.InserirMaterial(mat3);
                Console.WriteLine(" -> Materiais criados com sucesso.");

                // Criar Funcionário
                Funcionario func1 = Funcionario.CriarFuncionario("Manuel Silva", "Pedreiro", 10.0f);
                RegrasFuncionarios.RegistarFuncionario(func1);
                Console.WriteLine(" -> Funcionário registado com sucesso.");


                // -----------------------------------------------------------
                // 2. CRIAR UMA OBRA
                // -----------------------------------------------------------
                Console.WriteLine("\n[2] A criar uma Nova Obra...");

                // Definir datas
                DateTime inicio = DateTime.Now;
                DateTime fim = DateTime.Now.AddMonths(3);

                //criar obra
                Obra minhaObra = Obra.CriarObra("Reconstrução Vivenda T3", "Braga, Centro", inicio, fim);

                // Tentar validar e inserir a obra
                if (RegrasObras.NovaObra(minhaObra))
                {
                    Console.WriteLine($" -> Obra '{minhaObra.Nome}' criada com sucesso!");
                }


                // -----------------------------------------------------------
                // 3. ADICIONAR CUSTOS À OBRA
                // -----------------------------------------------------------
                Console.WriteLine("\n[3] A adicionar Materiais e Mão de Obra à Obra...");

                // Adicionar sacos de cimento
                minhaObra.AdicionarMaterial(mat1); // +5.50
                minhaObra.AdicionarMaterial(mat3); // +15.00

                // Adicionar funcionário
                minhaObra.AdicionarFuncionario(func1); // +10.00

                // Criar e adicionar serviço
                Servico servPintura = Servico.CriarServico("Pintura Exterior", "Mão de obra subcontratada", 500.0f);
                minhaObra.AdicionarServico(servPintura); // +500.00

                Console.WriteLine(" -> Itens adicionados à obra.");


                // -----------------------------------------------------------
                // 4. CALCULAR CUSTOS
                // -----------------------------------------------------------
                Console.WriteLine("\n[4] A calcular custos totais...");

                double custoTotal = minhaObra.CalcularCustoTotal();

                Console.WriteLine($" -> Custo calculado: {custoTotal:C} (Euros)");
                // Ex: 5.50 + 15.00 + 10.00 + 500.00 = 530.5


                // -----------------------------------------------------------
                // 5. Gravar em Ficheiro
                // -----------------------------------------------------------
                Console.WriteLine("\n[5] A gravar dados em disco...");

                if (RegrasObras.Gravar("obras.bin") && RegrasMateriais.Gravar("materiais.bin"))
                {
                    Console.WriteLine(" -> Ficheiros 'obras.bin' e 'materiais.bin' gravados com sucesso.");
                }
                else
                {
                    Console.WriteLine(" -> Erro ao gravar.");
                }

                Console.WriteLine("\n=================================================");
                Console.WriteLine("   DEMONSTRAÇÃO CONCLUÍDA COM SUCESSO!           ");
                Console.WriteLine("=================================================");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n❌ ERRO CRÍTICO NA DEMONSTRAÇÃO: {ex.Message}");
            }

            // Pausa para ler o resultado
            Console.ReadKey();
        }
    }
}