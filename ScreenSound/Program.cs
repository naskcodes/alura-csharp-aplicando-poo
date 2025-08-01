using Comumusic;

Album albumPinkFloyd = new Album();
albumPinkFloyd.Nome = "The Wall";

Musica musica1 = new Musica();
musica1.Nome = "In the Flesh";
musica1.Duracao = 4;

Musica musica2 = new Musica();
musica2.Nome = "In the Flesh?";
musica2.Duracao = 3;

albumPinkFloyd.AdicionarMusica(musica1);
albumPinkFloyd.AdicionarMusica(musica2);
albumPinkFloyd.ExibirMusicasAlbum();