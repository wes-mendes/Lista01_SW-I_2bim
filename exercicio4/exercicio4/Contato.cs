using System;
using System.Collections.Generic;

class Contato
{
    // Atributos
    public string Nome { get; set; } // Nome do contato
    public string Telefone { get; set; } // Telefone do contato
    public string Email { get; set; } // Email do contato

    // Construtor
    public Contato(string nome, string telefone, string email)
    {
        Nome = nome; // Inicializa o atributo Nome
        Telefone = telefone; // Inicializa o atributo Telefone
        Email = email; // Inicializa o atributo Email
    }

    // Método para exibir informações do contato
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}"); // Exibe o nome do contato
        Console.WriteLine($"Telefone: {Telefone}"); // Exibe o telefone do contato
        Console.WriteLine($"Email: {Email}"); // Exibe o email do contato
    }
}
