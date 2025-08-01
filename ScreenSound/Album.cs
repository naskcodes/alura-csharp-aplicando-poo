using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comumusic
{
    class Album
    {
        public Album(string nome, Banda artista)
        {
            Nome = nome;
            Artista = artista;
        }

        private List<Musica> musicas = new List<Musica>();
        public string Nome { get; }
        public Banda Artista { get; }
        public int DuracaoTotal => musicas.Sum(m => m.Duracao);

        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }

        public void ExibirMusicasAlbum()
        {
            Console.WriteLine($"Músicas do álbum {Nome}:");
            foreach (var musica in musicas)
            {
                Console.WriteLine($"Música: {musica.Nome}");
            }
            Console.WriteLine($"Para apreciar o álbum completo, são necessários {DuracaoTotal} minutos");
        }
    }
}