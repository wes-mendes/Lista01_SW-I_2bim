// Classe interna para iniciar o programa
internal class Program
{
    // Método principal
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Animal *****");

        // Solicita informações do animal ao usuário
        Console.WriteLine("\nDigite as informações do Animal: ");
        Console.Write("Nome: ");
        string nomeDoAnimal = Console.ReadLine();
        Console.Write("Espécie: ");
        string especieDoAnimal = Console.ReadLine();
        Console.Write("Idade: ");
        int idadeDoAnimal = int.Parse(Console.ReadLine());
        Console.Write("Som: ");
        string somDoAnimal = Console.ReadLine();

        // Cria instância do animal com os dados informados
        Animal animal = new Animal(nomeDoAnimal, especieDoAnimal, idadeDoAnimal);

        Console.WriteLine("\n----- Resultado -----");
        Console.WriteLine($"Nome: {animal.Nome}");
        Console.WriteLine($"Espécie: {animal.Especie}");
        Console.WriteLine($"Idade: {animal.Idade} anos");
        Console.Write($"O animal emite o som: ");
        animal.EmitirSom(somDoAnimal);

        Console.ReadKey();
    }
}