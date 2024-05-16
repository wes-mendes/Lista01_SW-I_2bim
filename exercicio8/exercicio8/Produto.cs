// Definição da classe Produto
public class Produto
{
    // Atributos privados
    private string _nome;
    private Fabricante _fabricante;
    private double _preco;

    // Construtor para inicializar os atributos
    public Produto(string nome, Fabricante fabricante, double preco)
    {
        _nome = nome;
        _fabricante = fabricante;
        _preco = preco;
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
                Console.WriteLine("Erro: o nome do Produto não pode ser vazio ou nulo.");
            }

            _nome = value; // Atribui o valor à variável privada
        }
    }

    // Propriedade Fabricante sem validação
    public Fabricante Fabricante
    {
        get { return _fabricante; }
        set { _fabricante = value; }
    }

    // Propriedade Preco com validação
    public double Preco
    {
        get { return _preco; }
        set
        {
            // Verifica se o preço é negativo
            if (_preco < 0)
            {
                Console.WriteLine("Erro: o preço deve ser positivo.");
            }

            _preco = value; // Atribui o valor à variável privada
        }
    }
}
