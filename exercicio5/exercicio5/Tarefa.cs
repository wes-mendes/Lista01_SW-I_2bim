using System;
using System.Collections.Generic;

class Tarefa
{
    // Atributos
    public string Descricao { get; set; } // Descrição da tarefa
    public DateTime DataVencimento { get; set; } // Data de vencimento da tarefa

    // Construtor
    public Tarefa(string descricao, DateTime dataVencimento)
    {
        Descricao = descricao; // Inicializa o atributo Descricao
        DataVencimento = dataVencimento; // Inicializa o atributo DataVencimento
    }

    // Método para exibir informações da tarefa
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Descrição: {Descricao}"); // Exibe a descrição da tarefa
        Console.WriteLine($"Data de Vencimento: {DataVencimento.ToShortDateString()}"); // Exibe a data de vencimento da tarefa
    }

    // Método para verificar se a tarefa deve ser executada hoje
    public bool DeveExecutarHoje()
    {
        return DataVencimento.Date == DateTime.Today; // Verifica se a data de vencimento é igual à data de hoje
    }
}
