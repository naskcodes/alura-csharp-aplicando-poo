using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comumusic
{
    class Podcast
    {
        public Podcast(string host, string nome)
        {
            Host = host;
            Nome = nome;
        }

        private List<Episodio> episodios = new List<Episodio>();

        public string Host { get; }
        public string Nome { get; }
        public int TotalEpisodios { get; set; }

        public void AdicionarEpisodio(Episodio episodio)
        {
            episodios.Add(episodio);
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"{Nome}:");
            foreach (var episodio in episodios) 
            {
                Console.WriteLine($"Episódio: {episodio.Titulo}");
            }
        }
    }
}
