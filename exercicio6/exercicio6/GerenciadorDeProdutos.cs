class GerenciadorDeProdutos
{
    // Lista para armazenar os produtos
    private List<Produto> produtos;

    // Construtor
    public GerenciadorDeProdutos()
    {
        produtos = new List<Produto>(); // Inicializa a lista de produtos
    }

    // Método para adicionar um produto
    public void AdicionarProduto(Produto produto)
    {
        produtos.Add(produto); // Adiciona o produto à lista
        Console.WriteLine("Produto adicionado com sucesso!"); // Exibe mensagem de sucesso
    }

    // Método para listar todos os produtos
    public void ListarProdutos()
    {
        Console.WriteLine("Lista de Produtos:"); // Exibe o cabeçalho da lista de produtos
        foreach (var produto in produtos) // Percorre cada produto na lista
        {
            produto.ExibirInformacoes(); // Exibe as informações do produto
            Console.WriteLine(); // Adiciona uma linha em branco entre os produtos
        }
    }

    // Método para consultar um produto pelo código
    public Produto ConsultarProduto(int codigo)
    {
        foreach (var produto in produtos) // Percorre cada produto na lista
        {
            if (produto.Codigo == codigo) // Verifica se o código coincide
            {
                return produto; // Retorna o produto encontrado
            }
        }
        return null; // Retorna null se o produto não for encontrado
    }
}
