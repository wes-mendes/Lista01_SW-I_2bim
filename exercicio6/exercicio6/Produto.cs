using System;
using System.Collections.Generic;

class Produto
{
    // Atributos
    public int Codigo { get; set; } // Código do produto
    public string Nome { get; set; } // Nome do produto
    public double Preco { get; set; } // Preço do produto
    public int QuantidadeEstoque { get; set; } // Quantidade em estoque do produto

    // Construtor
    public Produto(int codigo, string nome, double preco, int quantidadeEstoque)
    {
        Codigo = codigo; // Inicializa o atributo Codigo
        Nome = nome; // Inicializa o atributo Nome
        Preco = preco; // Inicializa o atributo Preco
        QuantidadeEstoque = quantidadeEstoque; // Inicializa o atributo QuantidadeEstoque
    }

    // Método para exibir informações do produto
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Código: {Codigo}"); // Exibe o código do produto
        Console.WriteLine($"Nome: {Nome}"); // Exibe o nome do produto
        Console.WriteLine($"Preço: {Preco}"); // Exibe o preço do produto
        Console.WriteLine($"Quantidade em Estoque: {QuantidadeEstoque}"); // Exibe a quantidade em estoque do produto
    }
}


