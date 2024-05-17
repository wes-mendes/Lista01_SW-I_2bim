public class Agenda
{
    private List<Pessoa> pessoas = new List<Pessoa>();

    public void ArmazenaPessoa(string nome, int idade, float altura)
    {
        pessoas.Add(new Pessoa(nome, idade, altura));
    }

    public void RemovePessoa(string nome)
    {
        Pessoa pessoa = BuscaPessoa(nome);
        if (pessoa != null)
        {
            pessoas.Remove(pessoa);
        }
        else
        {
            Console.WriteLine("Pessoa não encontrada na agenda.");
        }
    }

    public Pessoa BuscaPessoa(string nome)
    {
        foreach (var pessoa in pessoas)
        {
            if (pessoa.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
            {
                return pessoa;
            }
        }
        return null;
    }

    public void ImprimeAgenda()
    {
        if (pessoas.Count == 0)
        {
            Console.WriteLine("Agenda vazia.");
        }
        else
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
        }
    }
}