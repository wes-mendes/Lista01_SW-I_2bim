using System;

class Produto
{
    // Atributos
    public string Nome { get; set; } // Nome do produto
    public decimal Preco { get; set; } // Preço do produto
    public int QuantidadeEmEstoque { get; private set; } // Quantidade de itens em estoque (propriedade somente leitura fora da classe)

    // Construtor
    public Produto(string nome, decimal preco, int quantidadeEmEstoque)
    {
        Nome = nome; // Inicializa o atributo Nome
        Preco = preco; // Inicializa o atributo Preco
        QuantidadeEmEstoque = quantidadeEmEstoque; // Inicializa o atributo QuantidadeEmEstoque
    }

    // Método para adicionar itens ao estoque
    public void AdicionarEstoque(int quantidade)
    {
        if (quantidade > 0) // Verifica se a quantidade a adicionar é positiva
        {
            QuantidadeEmEstoque += quantidade; // Adiciona a quantidade ao estoque
            Console.WriteLine($"{quantidade} unidades adicionadas ao estoque."); // Exibe mensagem de sucesso
        }
        else
        {
            Console.WriteLine("A quantidade a adicionar deve ser positiva."); // Exibe mensagem de erro
        }
    }

    // Método para remover itens do estoque
    public void RemoverEstoque(int quantidade)
    {
        if (quantidade > 0) // Verifica se a quantidade a remover é positiva
        {
            if (quantidade <= QuantidadeEmEstoque) // Verifica se há estoque suficiente para remover
            {
                QuantidadeEmEstoque -= quantidade; // Remove a quantidade do estoque
                Console.WriteLine($"{quantidade} unidades removidas do estoque."); // Exibe mensagem de sucesso
            }
            else
            {
                Console.WriteLine("Quantidade insuficiente em estoque para remover."); // Exibe mensagem de erro
            }
        }
        else
        {
            Console.WriteLine("A quantidade a remover deve ser positiva."); // Exibe mensagem de erro
        }
    }

    // Método para exibir as informações do produto
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Produto: {Nome}"); // Exibe o nome do produto
        Console.WriteLine($"Preço: {Preco:C}"); // Exibe o preço do produto (formatação de moeda)
        Console.WriteLine($"Quantidade em estoque: {QuantidadeEmEstoque}"); // Exibe a quantidade em estoque
    }
}