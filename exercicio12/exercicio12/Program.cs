class Program
{
    static void Main(string[] args)
    {
        Agenda agenda = new Agenda();

        while (true)
        {
            Console.WriteLine("\n***** Menu *****");
            Console.WriteLine("1. Armazenar Pessoa");
            Console.WriteLine("2. Remover Pessoa");
            Console.WriteLine("3. Buscar Pessoa");
            Console.WriteLine("4. Imprimir Agenda");
            Console.WriteLine("5. Sair");

            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Idade: ");
                    int idade = int.Parse(Console.ReadLine());
                    Console.Write("Altura: ");
                    float altura = float.Parse(Console.ReadLine());
                    agenda.ArmazenaPessoa(nome, idade, altura);
                    break;
                case "2":
                    Console.Write("Nome da pessoa a ser removida: ");
                    string nomeRemover = Console.ReadLine();
                    agenda.RemovePessoa(nomeRemover);
                    break;
                case "3":
                    Console.Write("Nome da pessoa a ser buscada: ");
                    string nomeBuscar = Console.ReadLine();
                    Pessoa pessoa = agenda.BuscaPessoa(nomeBuscar);
                    if (pessoa != null)
                    {
                        Console.WriteLine("Pessoa encontrada: " + pessoa);
                    }
                    else
                    {
                        Console.WriteLine("Pessoa não encontrada na agenda.");
                    }
                    break;
                case "4":
                    Console.WriteLine("\n***** Agenda *****");
                    agenda.ImprimeAgenda();
                    break;
                case "5":
                    Console.WriteLine("Saindo...");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}