using Comumusic;

class Musica
{
    public Musica(Banda artista, string nome) 
    { 
        Artista = artista;
        Nome = nome;
    }

    public string Nome {  get; }
    public Banda Artista {  get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"{Nome} - {Artista.Nome}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine(DescricaoResumida);
        if (Disponivel)
        {
            Console.WriteLine("Incluso no plano.");
        } else
        {
            Console.WriteLine("Adquira o plano Comumusic+");
        }
    }
}