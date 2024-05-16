using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // Criando uma instância da classe CorretoraDeImoveis
        CorretoraDeImoveis corretora = new CorretoraDeImoveis();

        // Menu interativo
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Inserir imóvel");
            Console.WriteLine("2. Alterar preço do imóvel");
            Console.WriteLine("3. Listar todos os imóveis");
            Console.WriteLine("4. Calcular valor médio dos imóveis");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    // Inserir imóvel
                    Console.Write("Digite o endereço do imóvel: ");
                    string endereco = Console.ReadLine();
                    Console.Write("Digite o preço do imóvel: ");
                    decimal preco = decimal.Parse(Console.ReadLine());
                    Console.Write("Digite o tipo do imóvel: ");
                    string tipo = Console.ReadLine();

                    Imovel novoImovel = new Imovel(endereco, preco, tipo); // Cria uma nova instância de Imovel
                    corretora.AdicionarImovel(novoImovel); // Adiciona o novo imóvel à corretora
                    break;

                case 2:
                    // Alterar preço do imóvel
                    Console.Write("Digite o endereço do imóvel: ");
                    string enderecoParaAlterar = Console.ReadLine();
                    Console.Write("Digite o novo preço do imóvel: ");
                    decimal novoPreco = decimal.Parse(Console.ReadLine());

                    corretora.AlterarPreco(enderecoParaAlterar, novoPreco); // Altera o preço do imóvel
                    break;

                case 3:
                    // Listar todos os imóveis
                    corretora.ListarImoveis(); // Lista todos os imóveis
                    break;

                case 4:
                    // Calcular valor médio dos imóveis
                    decimal valorMedio = corretora.CalcularValorMedio(); // Calcula o valor médio
                    Console.WriteLine($"Valor médio dos imóveis: {valorMedio:C}"); // Exibe o valor médio formatado como moeda
                    break;

                case 5:
                    // Sair
                    return; // Encerra o programa

                default:
                    Console.WriteLine("Opção inválida!"); // Exibe mensagem de erro para opção inválida
                    break;
            }

            Console.WriteLine(); // Adiciona uma linha em branco para separação
        }
    }
}
