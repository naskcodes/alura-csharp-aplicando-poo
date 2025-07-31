Musica musica1 = new Musica();
musica1.nome = "Metallic Stallion";
musica1.artista = "Marina";
musica1.duracao = 273;
musica1.Disponivel = true;

Musica musica2 = new Musica();
musica2.nome = "La Comuna";
musica2.artista = "El Espectro";
musica2.duracao = 367;
musica2.Disponivel = false;
Console.WriteLine(musica2.Disponivel);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();