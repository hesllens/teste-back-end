using System;

namespace DiscontoBlackFriday
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Escolher produto com valor pré-definido");
                Console.WriteLine("2 - Digitar valor e nome do produto");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("=============================================");

                int opcaoSelecao = Convert.ToInt32(Console.ReadLine());

                if (opcaoSelecao == 0)
                {
                    Console.WriteLine("Saindo...");
                    break;
                }
                else if (opcaoSelecao == 1)
                {

                    Console.WriteLine("Selecione um produto:");
                    Console.WriteLine("1 - Notebook Dell");
                    Console.WriteLine("2 - Teclado Microsoft");
                    Console.WriteLine("=============================================");

                    int opcaoProduto = Convert.ToInt32(Console.ReadLine());

                    double valorProduto = 0;
                    string nomeProduto = "";

                    switch (opcaoProduto)
                    {
                        case 1:
                            valorProduto = 2834.53;
                            nomeProduto = "Notebook Dell";
                            break;
                        case 2:
                            valorProduto = 148.00;
                            nomeProduto = "Teclado Microsoft";
                            break;
                        default:
                            Console.WriteLine("Opção inválida! Tente novamente.");
                            continue; // Volta ao início do loop
                    }

                    CalcularDescontoEExibir(nomeProduto, valorProduto);
                }
                else if (opcaoSelecao == 2)
                {

                    Console.WriteLine("Digite o nome do produto:");
                    string nomeProduto = Console.ReadLine();

                    Console.WriteLine("Digite o valor do produto:");
                    double valorProduto = Convert.ToDouble(Console.ReadLine());

                    CalcularDescontoEExibir(nomeProduto, valorProduto);
                    Console.WriteLine("=============================================");
                }
                else
                {
                    Console.WriteLine("Opção inválida! Tente novamente.");
                }
            }
        }

        static void CalcularDescontoEExibir(string nomeProduto, double valorProduto)
        {
            double desconto = 0.60;
            double valorComDesconto = valorProduto * (1 - desconto);
            double valorDoDesconto = valorProduto - valorComDesconto;


            Console.WriteLine("Produto: " + nomeProduto);
            Console.WriteLine("Produto custava: " + valorProduto.ToString("C2"));
            Console.WriteLine("Com o desconto: " + valorComDesconto.ToString("C2"));
            Console.WriteLine("Valor do desconto: " + valorDoDesconto.ToString("C2"));

        }
    }
}