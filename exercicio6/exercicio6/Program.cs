class Program
{
    static void Main()
    {
        // Criando uma instância da classe GerenciadorDeProdutos
        GerenciadorDeProdutos gerenciador = new GerenciadorDeProdutos();

        // Menu interativo
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Adicionar produto");
            Console.WriteLine("2. Listar todos os produtos");
            Console.WriteLine("3. Consultar produto pelo código");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    // Adicionar produto
                    Console.Write("Digite o código do produto: ");
                    int codigo = int.Parse(Console.ReadLine());
                    Console.Write("Digite o nome do produto: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite o preço do produto: ");
                    double preco = double.Parse(Console.ReadLine());
                    Console.Write("Digite a quantidade em estoque do produto: ");
                    int quantidadeEstoque = int.Parse(Console.ReadLine());

                    Produto novoProduto = new Produto(codigo, nome, preco, quantidadeEstoque); // Cria uma nova instância de Produto
                    gerenciador.AdicionarProduto(novoProduto); // Adiciona o novo produto ao gerenciador
                    break;

                case 2:
                    // Listar todos os produtos
                    gerenciador.ListarProdutos(); // Lista todos os produtos
                    break;

                case 3:
                    // Consultar produto pelo código
                    Console.Write("Digite o código do produto a ser consultado: ");
                    int codigoParaConsultar = int.Parse(Console.ReadLine());

                    Produto produtoEncontrado = gerenciador.ConsultarProduto(codigoParaConsultar); // Consulta o produto pelo código
                    if (produtoEncontrado != null) // Verifica se o produto foi encontrado
                    {
                        produtoEncontrado.ExibirInformacoes(); // Exibe as informações do produto encontrado
                    }
                    else
                    {
                        Console.WriteLine("Produto não encontrado!"); // Exibe mensagem de erro se o produto não for encontrado
                    }
                    break;

                case 4:
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
