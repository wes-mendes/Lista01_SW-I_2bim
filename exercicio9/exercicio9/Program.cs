// Classe interna para iniciar o programa
internal class Program
{
    // Método principal
    private static void Main(string[] args)
    {
        Console.WriteLine("******** Livro ********");

        // Solicita informações do livro ao usuário
        Console.WriteLine("Digite os dados do Livro: ");
        Console.Write("Título: ");
        string tituloDoLivro = Console.ReadLine();
        Console.Write("Autor: ");
        string nomeDoAutor = Console.ReadLine();

        Console.WriteLine("\n-------- Resultado --------");

        try
        {
            // Cria instância do livro com os dados informados
            Livro livro = new Livro(tituloDoLivro, nomeDoAutor);
            Console.WriteLine($"Título: {livro.Titulo}");
            Console.WriteLine($"Autor: {livro.Autor}");
        }
        // Captura exceções do tipo ArgumentException
        catch (ArgumentException exception)
        {
            Console.WriteLine($"Erro: {exception.Message}");
        }

        Console.ReadKey();
    }
}