using System;
using System.Collections.Generic;

class Compra
{
    // Atributos
    public DateTime Data { get; set; } // Data da compra
    public string Produto { get; set; } // Nome do produto comprado
    public decimal Valor { get; set; } // Valor da compra

    // Construtor
    public Compra(DateTime data, string produto, decimal valor)
    {
        Data = data; // Inicializa o atributo Data
        Produto = produto; // Inicializa o atributo Produto
        Valor = valor; // Inicializa o atributo Valor
    }

    // Método para exibir informações da compra
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Data: {Data.ToShortDateString()}"); // Exibe a data da compra
        Console.WriteLine($"Produto: {Produto}"); // Exibe o nome do produto
        Console.WriteLine($"Valor: {Valor:C}"); // Exibe o valor da compra (formatação de moeda)
    }
}

class RegistroDeCompras
{
    // Lista para armazenar as compras
    private List<Compra> compras;

    // Construtor
    public RegistroDeCompras()
    {
        compras = new List<Compra>(); // Inicializa a lista de compras
    }

    // Método para adicionar uma compra
    public void AdicionarCompra(Compra compra)
    {
        compras.Add(compra); // Adiciona a compra à lista
        Console.WriteLine("Compra adicionada com sucesso!"); // Exibe mensagem de sucesso
    }

    // Método para listar todas as compras
    public void ListarCompras()
    {
        Console.WriteLine("Lista de Compras:"); // Exibe o cabeçalho da lista de compras
        foreach (var compra in compras) // Percorre cada compra na lista
        {
            compra.ExibirInformacoes(); // Exibe as informações da compra
            Console.WriteLine(); // Adiciona uma linha em branco entre as compras
        }
    }
}
