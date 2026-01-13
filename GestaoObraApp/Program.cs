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
                RegrasMateriais regrasMat = new RegrasMateriais();
                RegrasFuncionarios regrasFunc = new RegrasFuncionarios();
                RegrasObras regrasObra = new RegrasObras();

                // -----------------------------------------------------------
                // 1. CRIAR DADOS
                // -----------------------------------------------------------
                Console.WriteLine("\n[1] A Inicializar Catálogos (Materiais e Funcionários)...");

                // Criar alguns materiais
                Material mat1 = new Material("Cimento", "Saco 25kg", 5.50f);
                Material mat2 = new Material("Tijolo", "Bloco térmico", 0.80f);
                Material mat3 = new Material("Areia", "Metro Cúbico", 15.0f);

                // Inserir no sistema (Regras valida e manda para Dados)
                regrasMat.InserirMaterial(mat1);
                regrasMat.InserirMaterial(mat2);
                regrasMat.InserirMaterial(mat3);
                Console.WriteLine(" -> Materiais criados com sucesso.");

                // Criar Funcionário
                Funcionario func1 = new Funcionario("Manuel Silva", "Pedreiro", 10.0f);

                regrasFunc.RegistarFuncionario(func1);
                Console.WriteLine(" -> Funcionário registado com sucesso.");


                // -----------------------------------------------------------
                // 2. CRIAR UMA OBRA
                // -----------------------------------------------------------
                Console.WriteLine("\n[2] A criar uma Nova Obra...");

                // Definir datas
                DateTime inicio = DateTime.Now;
                DateTime fim = DateTime.Now.AddMonths(3);

                //criar obra
                Obra minhaObra = new Obra("Reconstrução Vivenda T3", "Braga, Centro", inicio, fim);

                // Tentar validar e inserir a obra
                try
                {
                    if (regrasObra.NovaObra(minhaObra))
                    {
                        Console.WriteLine($" -> Obra '{minhaObra.Nome}' criada com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao criar obra: {ex.Message}");
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
                Servico servPintura = new Servico("Pintura Exterior", "Mão de obra subcontratada", 500.0f);
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

                try
                {
                    // Aqui usamos as instâncias regrasObra e regrasMat para chamar o Gravar
                    bool gravouObras = regrasObra.Gravar("obras.bin");
                    bool gravouMat = regrasMat.Gravar("materiais.bin");

                    if (gravouObras && gravouMat)
                    {
                        Console.WriteLine(" -> Ficheiros 'obras.bin' e 'materiais.bin' gravados com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine(" -> Aviso: Um dos ficheiros pode não ter sido gravado.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($" -> ERRO AO GRAVAR: {ex.Message}");
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