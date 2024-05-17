// Definição da classe Carro
public class Carro
{
    // Atributos privados
    private string _modelo; // Modelo do carro
    private int _ano; // Ano de fabricação do carro
    private int _velocidade; // Velocidade atual do carro

    // Construtor para inicializar os atributos
    public Carro(string modelo, int ano)
    {
        _modelo = modelo;
        _ano = ano;
        _velocidade = 0; // Inicializa a velocidade como zero
    }

    // Propriedades Modelo e Ano com métodos de acesso para leitura e escrita
    public string Modelo
    {
        get { return _modelo; }
        set { _modelo = value; }
    }

    public int Ano
    {
        get { return _ano; }
        set { _ano = value; }
    }

    // Propriedade Velocidade apenas com método de acesso para leitura
    public int Velocidade
    {
        get { return _velocidade; }
    }

    // Método para acelerar o carro (aumentando a velocidade em 10)
    public void Acelerar()
    {
        _velocidade += 10;
    }

    // Método para frear o carro (diminuindo a velocidade em 10, mas nunca deixando a velocidade negativa)
    public void Frear()
    {
        if (_velocidade >= 10)
        {
            _velocidade -= 10;
        }
        else
        {
            _velocidade = 0;
        }
    }
}