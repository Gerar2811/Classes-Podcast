class Episodio
{

    private new List<string> convidados = new List<string>();
    public int Duracao { get; set; }
    public int Ordem { get; set; }

    //Ordem, titulo e duracao
    public string Resumo => $"Episodio #{Ordem}: {Titulo} - {Duracao} Minutos. Junto com: {string.Join(", ",convidados)}";
    public string Titulo { get; set; }

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}