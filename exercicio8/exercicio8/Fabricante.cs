using System;

// Definição da classe Fabricante
public class Fabricante
{
    // Atributos privados
    private string _nome;
    private string _endereco;
    private string _cidade;

    // Construtor para inicializar os atributos
    public Fabricante(string nome, string endereco, string cidade)
    {
        _nome = nome;
        _endereco = endereco;
        _cidade = cidade;
    }

    // Propriedade Nome com validação
    public string Nome
    {
        get { return _nome; }
        set
        {
            // Verifica se o valor é nulo ou vazio
            if (value == null || value.Length == 0)
            {
                Console.WriteLine("Erro: o nome do Fabricante não pode ser vazio ou nulo.");
            }

            _nome = value; // Atribui o valor à variável privada
        }
    }

    // Propriedades de Endereco e Cidade sem validação
    public string Endereco
    {
        get { return _endereco; }
        set { _endereco = value; }
    }

    public string Cidade
    {
        get { return _cidade; }
        set { _cidade = value; }
    }
}
