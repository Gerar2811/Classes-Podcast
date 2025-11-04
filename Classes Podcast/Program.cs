Podcast podcast1 = new Podcast("Leo Rojas", "Escuela de nada");
Episodio episodio1 = new Episodio()
{
    Duracao = 50,
    Ordem= 692,
    Titulo= "Los reality show son zoológicos de personas?",
};

Episodio episodio2 = new Episodio()
{
    Duracao = 69,
    Ordem = 681,
    Titulo = "La mayoria de personas en el mundo son estupidas",
};

Episodio episodio3 = new Episodio()
{
    Duracao = 50,
    Ordem = 625,
    Titulo = "La muerte del romance en la música",
};


Episodio episodio4 = new Episodio()
{
    Duracao = 70,
    Ordem = 616,
    Titulo = "Los fetiches mas extraños en una relacion",
};

podcast1.AdicionarEpisodio(episodio1);
podcast1.AdicionarEpisodio(episodio2);
podcast1.AdicionarEpisodio(episodio3);
podcast1.AdicionarEpisodio(episodio4);

episodio1.AdicionarConvidados("Carlos");
episodio1.AdicionarConvidados("Ana");

episodio2.AdicionarConvidados("Maria");

episodio3.AdicionarConvidados("Jorge");

episodio4.AdicionarConvidados("Luisa");

podcast1.ExibirDetalhes();



