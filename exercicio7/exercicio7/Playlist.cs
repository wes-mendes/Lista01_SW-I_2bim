public class Playlist
{
    private List<Musica> listaDeMusicas = new List<Musica>();
    public string dono;

    public Playlist(string dono)
    {
        this.dono = dono;
    }

    public void AdicionarMusica(Musica musica)
    {
        listaDeMusicas.Add(musica);
    }

    public void TocarMusicaAleatoria()
    {
        if (listaDeMusicas.Count > 0)
        {
            Random random = new Random();
            int indiceAleatorio = random.Next(listaDeMusicas.Count);
            Musica musicaTocada = listaDeMusicas[indiceAleatorio];
            Console.WriteLine($"Tocando a musica: {musicaTocada.nome} - {musicaTocada.autor}");
        }
        else
        {
            Console.WriteLine("A playlist está vazia. Adicione músicas antes de tocar.");
        }
    }
}
