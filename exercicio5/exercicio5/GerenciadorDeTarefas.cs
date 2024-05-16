class GerenciadorDeTarefas
{
    // Lista para armazenar as tarefas
    private List<Tarefa> tarefas;

    // Construtor
    public GerenciadorDeTarefas()
    {
        tarefas = new List<Tarefa>(); // Inicializa a lista de tarefas
    }

    // Método para adicionar uma tarefa
    public void AdicionarTarefa(Tarefa tarefa)
    {
        tarefas.Add(tarefa); // Adiciona a tarefa à lista
        Console.WriteLine("Tarefa adicionada com sucesso!"); // Exibe mensagem de sucesso
    }

    // Método para remover uma tarefa pela descrição
    public void RemoverTarefa(string descricao)
    {
        Tarefa tarefaParaRemover = null; // Inicializa a variável de referência para a tarefa a ser removida
        foreach (var tarefa in tarefas) // Percorre cada tarefa na lista
        {
            if (tarefa.Descricao == descricao) // Verifica se a descrição coincide
            {
                tarefaParaRemover = tarefa; // Define a tarefa a ser removida
                break; // Sai do loop após encontrar a tarefa
            }
        }
        if (tarefaParaRemover != null) // Verifica se a tarefa foi encontrada
        {
            tarefas.Remove(tarefaParaRemover); // Remove a tarefa da lista
            Console.WriteLine("Tarefa removida com sucesso!"); // Exibe mensagem de sucesso
        }
        else
        {
            Console.WriteLine("Tarefa não encontrada!"); // Exibe mensagem de erro se a tarefa não for encontrada
        }
    }

    // Método para listar todas as tarefas
    public void ListarTarefas()
    {
        Console.WriteLine("Lista de Tarefas:"); // Exibe o cabeçalho da lista de tarefas
        foreach (var tarefa in tarefas) // Percorre cada tarefa na lista
        {
            tarefa.ExibirInformacoes(); // Exibe as informações da tarefa
            Console.WriteLine(); // Adiciona uma linha em branco entre as tarefas
        }
    }

    // Método para listar as tarefas que devem ser executadas hoje
    public void ListarTarefasDeHoje()
    {
        Console.WriteLine("Tarefas para Hoje:"); // Exibe o cabeçalho da lista de tarefas para hoje
        bool encontrouTarefas = false; // Flag para verificar se encontrou tarefas para hoje
        foreach (var tarefa in tarefas) // Percorre cada tarefa na lista
        {
            if (tarefa.DeveExecutarHoje()) // Verifica se a tarefa deve ser executada hoje
            {
                tarefa.ExibirInformacoes(); // Exibe as informações da tarefa
                encontrouTarefas = true; // Seta a flag para indicar que encontrou tarefas
                Console.WriteLine(); // Adiciona uma linha em branco entre as tarefas
            }
        }
        if (!encontrouTarefas)
        {
            Console.WriteLine("Nenhuma tarefa para hoje!"); // Exibe mensagem se não houver tarefas para hoje
        }
    }
}
