using Comumusic;

Banda pinkFloyd = new Banda("Pink Floyd");
Album albumPinkFloyd = new Album("The Wall", pinkFloyd);
Musica musica1 = new Musica(pinkFloyd, "In the Flesh")
{
    Duracao = 4,
    Disponivel = true
};
Musica musica2 = new Musica(pinkFloyd, "In the Flesh?")
{
    Duracao = 3,
    Disponivel = false
};

albumPinkFloyd.AdicionarMusica(musica1);
albumPinkFloyd.AdicionarMusica(musica2);
pinkFloyd.AdicionarAlbum(albumPinkFloyd);
pinkFloyd.ExibirDiscografia();
musica1.ExibirFichaTecnica();