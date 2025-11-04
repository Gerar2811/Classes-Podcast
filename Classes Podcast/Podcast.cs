class Podcast
{

     List<Episodio> episodios = new List<Episodio>();

    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get;}
    public string Nome { get;}
    public int TotalEpisodios => episodios.Count;
    public int DuracaoTotal => episodios.Sum(e => e.Duracao);

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
        //episodios.Sort((e1, e2) => e1.Ordem.CompareTo(e2.Ordem));
    }

    // Precisa exibir o nome, host, episodios em ordem e total de episodios
    public void ExibirDetalhes()
    {
        Console.WriteLine($"Episodios de * {Nome} *\n");
        

        foreach (Episodio episodio in episodios.OrderBy(e=>e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }

        Console.WriteLine($"\nTotal de Episodios: {TotalEpisodios}");
        Console.WriteLine($"Duracao Total: {DuracaoTotal} minutos");
    }

}