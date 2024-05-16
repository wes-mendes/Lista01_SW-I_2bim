class AgendaTelefonica
{
    // Lista para armazenar os contatos
    private List<Contato> contatos;

    // Construtor
    public AgendaTelefonica()
    {
        contatos = new List<Contato>(); // Inicializa a lista de contatos
    }

    // Método para adicionar um contato
    public void AdicionarContato(Contato contato)
    {
        contatos.Add(contato); // Adiciona o contato à lista
        Console.WriteLine("Contato adicionado com sucesso!"); // Exibe mensagem de sucesso
    }

    // Método para remover um contato pelo nome
    public void RemoverContato(string nome)
    {
        Contato contatoParaRemover = null; // Inicializa a variável de referência para o contato a ser removido
        foreach (var contato in contatos) // Percorre cada contato na lista
        {
            if (contato.Nome == nome) // Verifica se o nome coincide
            {
                contatoParaRemover = contato; // Define o contato a ser removido
                break; // Sai do loop após encontrar o contato
            }
        }
        if (contatoParaRemover != null) // Verifica se o contato foi encontrado
        {
            contatos.Remove(contatoParaRemover); // Remove o contato da lista
            Console.WriteLine("Contato removido com sucesso!"); // Exibe mensagem de sucesso
        }
        else
        {
            Console.WriteLine("Contato não encontrado!"); // Exibe mensagem de erro se o contato não for encontrado
        }
    }

    // Método para buscar um contato pelo nome
    public Contato BuscarContato(string nome)
    {
        foreach (var contato in contatos) // Percorre cada contato na lista
        {
            if (contato.Nome == nome) // Verifica se o nome coincide
            {
                return contato; // Retorna o contato encontrado
            }
        }
        return null; // Retorna null se o contato não for encontrado
    }

    // Método para listar todos os contatos
    public void ListarContatos()
    {
        Console.WriteLine("Lista de Contatos:"); // Exibe o cabeçalho da lista de contatos
        foreach (var contato in contatos) // Percorre cada contato na lista
        {
            contato.ExibirInformacoes(); // Exibe as informações do contato
            Console.WriteLine(); // Adiciona uma linha em branco entre os contatos
        }
    }
}

