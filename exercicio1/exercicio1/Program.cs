class Program
{
    static void Main()
    {
        // Criando uma instância da classe Produto
        Produto produto = new Produto("Caneta", 2.50m, 100);

        // Exibindo as informações do produto
        produto.ExibirInformacoes();

        // Adicionando itens ao estoque
        produto.AdicionarEstoque(50);
        produto.ExibirInformacoes();

        // Removendo itens do estoque
        produto.RemoverEstoque(30);
        produto.ExibirInformacoes();

        // Tentando remover mais itens do que o disponível
        produto.RemoverEstoque(150);
        produto.ExibirInformacoes();
    }
}