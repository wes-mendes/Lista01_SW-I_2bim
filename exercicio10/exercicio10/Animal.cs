// Definição da classe Animal
public class Animal
{
    // Atributos privados
    private string _nome;
    private string _especie;
    private int _idade;

    // Construtor para inicializar os atributos
    public Animal(string nome, string especie, int idade)
    {
        _nome = nome;
        _especie = especie;
        _idade = idade;
    }

    // Propriedades Nome, Especie e Idade
    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    public string Especie
    {
        get { return _especie; }
        set { _especie = value; }
    }

    public int Idade
    {
        get { return _idade; }
        set { _idade = value; }
    }

    // Método para emitir som do animal
    public void EmitirSom(string somDoAnimal)
    {
        Console.WriteLine(somDoAnimal);
    }
}
