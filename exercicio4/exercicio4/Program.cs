class Program
{
    static void Main()
    {
        // Criando uma instância da classe AgendaTelefonica
        AgendaTelefonica agenda = new AgendaTelefonica();

        // Menu interativo
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Adicionar contato");
            Console.WriteLine("2. Remover contato");
            Console.WriteLine("3. Buscar contato");
            Console.WriteLine("4. Listar todos os contatos");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    // Adicionar contato
                    Console.Write("Digite o nome do contato: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite o telefone do contato: ");
                    string telefone = Console.ReadLine();
                    Console.Write("Digite o email do contato: ");
                    string email = Console.ReadLine();

                    Contato novoContato = new Contato(nome, telefone, email); // Cria uma nova instância de Contato
                    agenda.AdicionarContato(novoContato); // Adiciona o novo contato à agenda
                    break;

                case 2:
                    // Remover contato
                    Console.Write("Digite o nome do contato a ser removido: ");
                    string nomeParaRemover = Console.ReadLine();

                    agenda.RemoverContato(nomeParaRemover); // Remove o contato da agenda
                    break;

                case 3:
                    // Buscar contato
                    Console.Write("Digite o nome do contato a ser buscado: ");
                    string nomeParaBuscar = Console.ReadLine();

                    Contato contatoEncontrado = agenda.BuscarContato(nomeParaBuscar); // Busca o contato na agenda
                    if (contatoEncontrado != null) // Verifica se o contato foi encontrado
                    {
                        contatoEncontrado.ExibirInformacoes(); // Exibe as informações do contato encontrado
                    }
                    else
                    {
                        Console.WriteLine("Contato não encontrado!"); // Exibe mensagem de erro se o contato não for encontrado
                    }
                    break;

                case 4:
                    // Listar todos os contatos
                    agenda.ListarContatos(); // Lista todos os contatos
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
