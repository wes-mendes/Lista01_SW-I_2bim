class CorretoraDeImoveis
{
    // Lista para armazenar os imóveis
    private List<Imovel> imoveis;

    // Construtor
    public CorretoraDeImoveis()
    {
        imoveis = new List<Imovel>(); // Inicializa a lista de imóveis
    }

    // Método para adicionar um imóvel
    public void AdicionarImovel(Imovel imovel)
    {
        imoveis.Add(imovel); // Adiciona o imóvel à lista
        Console.WriteLine("Imóvel adicionado com sucesso!"); // Exibe mensagem de sucesso
    }

    // Método para alterar o preço de um imóvel
    public void AlterarPreco(string endereco, decimal novoPreco)
    {
        foreach (var imovel in imoveis) // Percorre cada imóvel na lista
        {
            if (imovel.Endereco == endereco) // Verifica se o endereço coincide
            {
                imovel.Preco = novoPreco; // Altera o preço do imóvel
                Console.WriteLine("Preço do imóvel alterado com sucesso!"); // Exibe mensagem de sucesso
                return;
            }
        }
        Console.WriteLine("Imóvel não encontrado!"); // Exibe mensagem de erro se o imóvel não for encontrado
    }

    // Método para listar todos os imóveis
    public void ListarImoveis()
    {
        Console.WriteLine("Lista de Imóveis Disponíveis:"); // Exibe o cabeçalho da lista de imóveis
        foreach (var imovel in imoveis) // Percorre cada imóvel na lista
        {
            imovel.ExibirInformacoes(); // Exibe as informações do imóvel
            Console.WriteLine(); // Adiciona uma linha em branco entre os imóveis
        }
    }

    // Método para calcular o valor médio dos imóveis
    public decimal CalcularValorMedio()
    {
        if (imoveis.Count == 0) // Verifica se a lista de imóveis está vazia
        {
            return 0; // Retorna 0 se não houver imóveis
        }

        decimal soma = 0; // Variável para armazenar a soma dos preços
        foreach (var imovel in imoveis) // Percorre cada imóvel na lista
        {
            soma += imovel.Preco; // Adiciona o preço do imóvel à soma
        }
        return soma / imoveis.Count; // Calcula e retorna o valor médio
    }
}
