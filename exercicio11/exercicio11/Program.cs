// Classe interna para iniciar o programa
internal class Program
{
    // Método principal
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Meu Carro *****");

        // Solicita informações do carro ao usuário
        Console.WriteLine("\nDigite as informações do seu carro:");
        Console.Write("Modelo: ");
        string modeloDoCarro = Console.ReadLine();
        Console.Write("Ano: ");
        int anoDeFabricacao = int.Parse(Console.ReadLine());

        // Cria instância do carro com os dados informados
        Carro carro = new Carro(modeloDoCarro, anoDeFabricacao);

        // Exibe os resultados na tela
        Console.WriteLine("\n---------------- Resultado ----------------");
        Console.WriteLine($"Modelo: {carro.Modelo}, Ano: {carro.Ano}, Velocidade: {carro.Velocidade}");

        // Acelera o carro duas vezes e verifica a velocidade
        carro.Acelerar();
        Console.WriteLine($"Acelerando... Velocidade: {carro.Velocidade}");

        carro.Acelerar();
        Console.WriteLine($"Acelerando mais uma vez... Velocidade: {carro.Velocidade}");

        // Freia o carro duas vezes e verifica a velocidade
        carro.Frear();
        Console.WriteLine($"Freando uma vez... Velocidade: {carro.Velocidade}");

        carro.Frear();
        Console.WriteLine($"Freando... Velocidade: {carro.Velocidade}");

        Console.ReadKey();
    }
}