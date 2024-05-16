class Program
{
    static void Main()
    {
        // Criando uma instância da classe GerenciadorDeTarefas
        GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();

        // Menu interativo
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Adicionar tarefa");
            Console.WriteLine("2. Remover tarefa");
            Console.WriteLine("3. Listar todas as tarefas");
            Console.WriteLine("4. Listar tarefas para hoje");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    // Adicionar tarefa
                    Console.Write("Digite a descrição da tarefa: ");
                    string descricao = Console.ReadLine();
                    Console.Write("Digite a data de vencimento da tarefa (dd/MM/yyyy): ");
                    DateTime dataVencimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                    Tarefa novaTarefa = new Tarefa(descricao, dataVencimento); // Cria uma nova instância de Tarefa
                    gerenciador.AdicionarTarefa(novaTarefa); // Adiciona a nova tarefa ao gerenciador
                    break;

                case 2:
                    // Remover tarefa
                    Console.Write("Digite a descrição da tarefa a ser removida: ");
                    string descricaoParaRemover = Console.ReadLine();

                    gerenciador.RemoverTarefa(descricaoParaRemover); // Remove a tarefa do gerenciador
                    break;

                case 3:
                    // Listar todas as tarefas
                    gerenciador.ListarTarefas(); // Lista todas as tarefas
                    break;

                case 4:
                    // Listar tarefas para hoje
                    gerenciador.ListarTarefasDeHoje(); // Lista as tarefas que devem ser executadas hoje
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
