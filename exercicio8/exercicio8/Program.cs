// Classe interna para iniciar o programa
internal class Program
{
    // Método principal
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Produtos e Fabricantes *****");

        // Solicita informações do fabricante
        Console.WriteLine("\nInforme os dados do Fabricante: ");

        Console.Write("Nome: ");
        string nomeDoFabricante = Console.ReadLine();

        Console.Write("Endereço: ");
        string endereco = Console.ReadLine();

        Console.Write("Cidade: ");
        string cidade = Console.ReadLine();

        // Solicita informações do produto
        Console.WriteLine("Informe os dados do Produto: ");

        Console.Write("Nome: ");
        string nomeDoProduto = Console.ReadLine();

        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine());

        // Cria instância do fabricante com os dados informados
        Fabricante fabricante = new Fabricante(nomeDoFabricante, endereco, cidade);

        // Cria instância do produto com os dados informados
        Produto produto = new Produto(nomeDoProduto, fabricante, preco);

        // Exibe o resultado na tela
        Console.WriteLine("\n----- Resultado -----");
        Console.WriteLine($"Produto: {produto.Nome}");
        Console.WriteLine($"Fabricante: {produto.Fabricante.Nome}");
        Console.WriteLine($"Preço: R${produto.Preco}");

        Console.ReadKey();
    }
}