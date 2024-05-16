// Definição da classe Livro
public class Livro
{
    // Atributos privados
    private string _titulo;
    private string _autor;

    // Construtor para inicializar os atributos
    public Livro(string titulo, string autor)
    {
        // Chamada do método para validar os dados
        ValidarDados(titulo, autor);

        // Atribuição dos valores aos atributos privados
        _titulo = titulo;
        _autor = autor;
    }

    // Propriedades Titulo e Autor
    public string Titulo
    {
        get { return _titulo; }
        set { _titulo = value; }
    }

    public string Autor
    {
        get { return _autor; }
        set { _autor = value; }
    }

    // Método privado para validar os dados
    private void ValidarDados(string titulo, string nome)
    {
        // Verifica se o título é vazio ou nulo
        if (string.IsNullOrWhiteSpace(titulo))
        {
            throw new ArgumentException("o título do livro não pode ser vazio ou nulo!");
        }
        // Verifica se o nome do autor é vazio ou nulo
        else if (string.IsNullOrWhiteSpace(nome))
        {
            throw new ArgumentException("o nome do autor não pode ser vazio ou nulo!");
        }
    }
}