class Imovel
{
    // Atributos
    public string Endereco { get; set; } // Endereço do imóvel
    public decimal Preco { get; set; } // Preço do imóvel
    public string Tipo { get; set; } // Tipo do imóvel (ex: apartamento, casa, etc.)

    // Construtor
    public Imovel(string endereco, decimal preco, string tipo)
    {
        Endereco = endereco; // Inicializa o atributo Endereco
        Preco = preco; // Inicializa o atributo Preco
        Tipo = tipo; // Inicializa o atributo Tipo
    }

    // Método para exibir informações do imóvel
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Endereço: {Endereco}"); // Exibe o endereço do imóvel
        Console.WriteLine($"Preço: {Preco:C}"); // Exibe o preço do imóvel (formatação de moeda)
        Console.WriteLine($"Tipo: {Tipo}"); // Exibe o tipo do imóvel
    }
}
