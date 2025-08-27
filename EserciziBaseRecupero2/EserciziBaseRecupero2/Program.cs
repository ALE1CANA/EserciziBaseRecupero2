public class DittaProduttrici
{
    public string codice;
    public string nome;
    public int annoInizio;
    public uint percentualeSconto;

    public DittaProduttrici(string codice, string nome, int annoInizio, uint percentualeSconto)
    {
        this.codice = codice;
        this.nome = nome;
        this.annoInizio = annoInizio;
        this.percentualeSconto = percentualeSconto;
    }

    public string Codice
    {
        get { return codice; }
        set { codice = value; }
    }
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
    public int AnnoInizio
    {
        get { return annoInizio; }
        set { annoInizio = value; }
    }
    public uint PercentualeSconto
    {
        get { return percentualeSconto; }
        set { percentualeSconto = value; }
    }
}

public class Accessori : DittaProduttrici
{
    private int codiceAccessorio;
    private string descrizione;
    private double costoAccessorio;

    public Accessori(string codice, string nome, int annoInizio, uint percentualeSconto, int codiceAccessorio, string descrizione, double costoAccessorio)
         : base(codice, nome, annoInizio, percentualeSconto) 
    {
        this.codiceAccessorio = codiceAccessorio;
        this.descrizione = descrizione;
        this.costoAccessorio = costoAccessorio;
    }
    public int CodiceAccessorio
    {
        get { return codiceAccessorio; }
        set { codiceAccessorio = value; }
    }
    public string Descrizione
    {
        get { return descrizione; }
        set { descrizione = value; }
    }
    public double CostoAccessorio
    {
        get { return costoAccessorio; }
        set { costoAccessorio = value; }
    }

}

public class Videogioco
{
    private string nome;
    private string descrizione;
    private DittaProduttrici dittaproduttrice;
    private int annoPubblicazione;
    private double costoVideogioco;
    private string piattaforma;

    public Videogioco(string nome, string descrizione, DittaProduttrici dittaproduttrice,int annoPubblicazione, double costoVideogioco, string piattaforma)
    {
        this.nome = nome;
        this.descrizione = descrizione;
        this.dittaproduttrice = dittaproduttrice;
        this.annoPubblicazione = annoPubblicazione;
        this.costoVideogioco = costoVideogioco;
        this.piattaforma = piattaforma;
    }
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public string Descrizione
    {
        get { return descrizione; }
        set { descrizione = value; }
    }

    public DittaProduttrici DittaProduttrice
    {
        get { return dittaproduttrice; }
        set { dittaproduttrice = value; }
    }

    public int AnnoPubblicazione
    {
        get { return annoPubblicazione; }
        set { annoPubblicazione = value; }
    }

    public double CostoVideogioco
    {
        get { return costoVideogioco; }
        set { costoVideogioco = value; }
    }

    public string Piattaforma
    {
        get { return piattaforma; }
        set { piattaforma = value; }
    }
}

public class VideogiocoPlus : Videogioco
{
    private Accessori accessorio;
    private string servizio;
    private double costoServizio;

    public VideogiocoPlus(string nome, string descrizione, DittaProduttrici dittaproduttrice,int annoPubblicazione, double costoVideogioco, string piattaforma,Accessori accessorio, string servizio, double costoServizio)
        : base(nome, descrizione, dittaproduttrice, annoPubblicazione, costoVideogioco, piattaforma)
    {
        this.accessorio = accessorio;
        this.servizio = servizio;
        this.costoServizio = costoServizio;
    }

    public Accessori Accessorio
    {
        get { return accessorio; }
        set { accessorio = value; }
    }

    public string Servizio
    {
        get { return servizio; }
        set { servizio = value; }
    }

    public double CostoServizio
    {
        get { return costoServizio; }
        set { costoServizio = value; }
    }
}
class Program
{
    static void Main()
    {
        List<DittaProduttrici> ditteProduttrici = new List<DittaProduttrici>();
        DittaProduttrici dittaproduttrice1 = new DittaProduttrici("AA11A", "Atari", 1980, 60);
        DittaProduttrici dittaproduttrice2 = new DittaProduttrici("BB11A", "Nintendo", 1990, 70);
        DittaProduttrici dittaproduttrice3 = new DittaProduttrici("CC11A", "Sony", 1990, 80);
        ditteProduttrici.Add(dittaproduttrice1);
        ditteProduttrici.Add(dittaproduttrice2);
        ditteProduttrici.Add(dittaproduttrice3);

        List<Videogioco> videogiochi = new List<Videogioco>();
        Videogioco videogioco1 = new Videogioco("FC26", "Gioco di calcio", dittaproduttrice1, 2025, 110, "Console");
        Videogioco videogioco2 = new Videogioco("GTA V", "Simulatore vita reale", dittaproduttrice2, 2017, 79.99, "PC");
        Videogioco videogioco3 = new Videogioco("Fortnite", "Gioco di guerra", dittaproduttrice3, 2014, 10.99, "Mobile");
        videogiochi.Add(videogioco1);
        videogiochi.Add(videogioco2);
        videogiochi.Add(videogioco3);

        List<Accessori> accessori = new List<Accessori>();
        Accessori accessori1 = new Accessori(dittaproduttrice1.Codice,dittaproduttrice1.Nome,dittaproduttrice1.AnnoInizio,dittaproduttrice1.PercentualeSconto,10, "Cuffie", 30);
        Accessori accessori2 = new Accessori(dittaproduttrice2.Codice,dittaproduttrice2.Nome,dittaproduttrice2.AnnoInizio,dittaproduttrice2.PercentualeSconto,11, "Joystick",50);
        Accessori accessori3 = new Accessori(dittaproduttrice3.Codice,dittaproduttrice3.Nome,dittaproduttrice3.AnnoInizio,dittaproduttrice3.PercentualeSconto,12, "Volante", 100);
        accessori.Add(accessori1);
        accessori.Add(accessori2);
        accessori.Add(accessori3);

        List<VideogiocoPlus> videogiochiPlus = new List<VideogiocoPlus>();
        VideogiocoPlus videogiocoPlus1 = new VideogiocoPlus(videogioco1.Nome, videogioco2.Descrizione, videogioco1.DittaProduttrice, videogioco1.AnnoPubblicazione, videogioco1.CostoVideogioco, videogioco1.Piattaforma, accessori1, "1000 crediti", 9.99);
        VideogiocoPlus videogiocoPlus2 = new VideogiocoPlus(videogioco2.Nome, videogioco2.Descrizione, videogioco2.DittaProduttrice, videogioco2.AnnoPubblicazione, videogioco2.CostoVideogioco, videogioco2.Piattaforma, accessori2, "Abbonamento multiplayer", 14.99);
        VideogiocoPlus videogiocoPlus3 = new VideogiocoPlus(videogioco3.Nome, videogioco3.Descrizione, videogioco3.DittaProduttrice, videogioco3.AnnoPubblicazione, videogioco3.CostoVideogioco, videogioco3.Piattaforma, accessori3, "Pacchetto extra", 4.99);
        videogiochiPlus.Add(videogiocoPlus1);
        videogiochiPlus.Add(videogiocoPlus2);
        videogiochiPlus.Add(videogiocoPlus3);

        for (int i = 0; i < ditteProduttrici.Count; i++)
        {
            Console.WriteLine($"Ditta {i + 1}: {ditteProduttrici[i].Codice}, {ditteProduttrici[i].Nome}, {ditteProduttrici[i].AnnoInizio}, {ditteProduttrici[i].PercentualeSconto}");
        }

        for (int i = 0; i < videogiochi.Count; i++)
        {
            Console.WriteLine($"Videogioco {i + 1}: {videogiochi[i].Nome}, {videogiochi[i].Descrizione}, {videogiochi[i].DittaProduttrice.Nome}, {videogiochi[i].AnnoPubblicazione}, {videogiochi[i].CostoVideogioco}, {videogiochi[i].Piattaforma}");
        }

        for (int i = 0; i < accessori.Count; i++)
        {
            Console.WriteLine($"Accessorio {i + 1}: {accessori[i].CodiceAccessorio}, {accessori[i].Descrizione}, {accessori[i].CostoAccessorio}, {accessori[i].Nome}");
        }

        for (int i = 0; i < videogiochiPlus.Count; i++)
        {
            Console.WriteLine($"VideogiocoPlus {i + 1}: {videogiochiPlus[i].Nome}, {videogiochiPlus[i].Descrizione}, {videogiochiPlus[i].DittaProduttrice.Nome}, {videogiochiPlus[i].AnnoPubblicazione}, {videogiochiPlus[i].CostoVideogioco}, {videogiochiPlus[i].Piattaforma}, {videogiochiPlus[i].Accessorio.Descrizione}, {videogiochiPlus[i].Servizio}, {videogiochiPlus[i].CostoServizio}");
        }

        Modifica(accessori, 10, "Cuffie stereo aggiornate", 35);
        Visualizza(videogiochi, videogiochiPlus, "Atari");
        Cancella(videogiochiPlus, 10);
        PiuEconomicoPerConsole(videogiochi, "PC");
        CostoMedioPerDitta(ditteProduttrici, videogiochi, videogiochiPlus);


    }
    public static void Modifica(List<Accessori> accessori, int codiceAccessorio, string nuovaDescrizione, double nuovoCosto)
    {
        for (int i = 0; i < accessori.Count; i++)
        {
            if (accessori[i].CodiceAccessorio == codiceAccessorio)
            {
                accessori[i].Descrizione = nuovaDescrizione;
                accessori[i].CostoAccessorio = nuovoCosto;
                Console.WriteLine($"MODIFICA: Accessorio {codiceAccessorio} modificato: {accessori[i].Descrizione}, {accessori[i].CostoAccessorio}");
            }
        }
        
    }
    public static void Visualizza(List<Videogioco> videogiochi, List<VideogiocoPlus> videogiochiPlus, string nomeDitta)
    {
        for (int i = 0; i < videogiochi.Count; i++)
        {
            if (videogiochi[i].DittaProduttrice.Nome == nomeDitta)
            {
                Console.WriteLine($"VISUALIZZA: {videogiochi[i].Nome}, {videogiochi[i].Descrizione}, {videogiochi[i].DittaProduttrice.Nome}, {videogiochi[i].Piattaforma}, {videogiochi[i].AnnoPubblicazione}, {videogiochi[i].CostoVideogioco}");
            }
        }

        for (int i = 0; i < videogiochiPlus.Count; i++)
        {
            if (videogiochiPlus[i].DittaProduttrice.Nome == nomeDitta)
            {
                double prezzo = videogiochiPlus[i].CostoVideogioco + videogiochiPlus[i].CostoServizio + videogiochiPlus[i].Accessorio.CostoAccessorio;
                Console.WriteLine($"VISUALIZZA PLUS: {videogiochiPlus[i].Nome}, {videogiochiPlus[i].Descrizione}, {videogiochiPlus[i].DittaProduttrice.Nome}, {videogiochiPlus[i].Piattaforma}, {videogiochiPlus[i].AnnoPubblicazione}, {prezzo}");
            }
        }
    }
    public static void Cancella(List<VideogiocoPlus> videogiochiPlus, int codiceAccessorio)
    {
        for (int i = videogiochiPlus.Count - 1; i >= 0; i--)
        {
            if (videogiochiPlus[i].Accessorio.CodiceAccessorio == codiceAccessorio)
            {
                Console.WriteLine($"CANCELLA: VideogiocoPlus con accessorio {codiceAccessorio} eliminato: {videogiochiPlus[i].Nome}");
                videogiochiPlus.RemoveAt(i);
            }
        }
    }
    public static void PiuEconomicoPerConsole(List<Videogioco> videogiochi, string piattaforma)
    {
        double minPrezzo = double.MaxValue;

        for (int i = 0; i < videogiochi.Count; i++)
        {
            if (videogiochi[i].Piattaforma == piattaforma && videogiochi[i].CostoVideogioco < minPrezzo)
            {
                minPrezzo = videogiochi[i].CostoVideogioco;
            }
        }
        for (int i = 0; i < videogiochi.Count; i++)
        {
            if (videogiochi[i].Piattaforma == piattaforma && videogiochi[i].CostoVideogioco == minPrezzo)
            {
                Console.WriteLine($"PIU ECONOMICO PER CONSOLE: {videogiochi[i].Piattaforma}: {videogiochi[i].DittaProduttrice.Codice}, {videogiochi[i].Nome}, {videogiochi[i].CostoVideogioco}");
            }
        }
    }
    public static void CostoMedioPerDitta(List<DittaProduttrici> ditteProduttrici, List<Videogioco> videogiochi, List<VideogiocoPlus> videogiochiPlus)
    {
        double somma = 0;
        int contatore = 0;
        double media;

        for (int i = 0; i < ditteProduttrici.Count; i++)
        {
            for (int j = 0; j < videogiochi.Count; j++)
            {
                if (videogiochi[j].DittaProduttrice == ditteProduttrici[i])
                {
                    somma += videogiochi[j].CostoVideogioco;
                    contatore++;
                }
            }

            for (int j = 0; j < videogiochiPlus.Count; j++)
            {
                if (videogiochiPlus[j].DittaProduttrice == ditteProduttrici[i])
                {
                    double prezzo = videogiochiPlus[j].CostoVideogioco + videogiochiPlus[j].CostoServizio + videogiochiPlus[j].Accessorio.CostoAccessorio;
                    somma += prezzo;
                    contatore++;
                }
            }
            media = somma / contatore;
            if (contatore > 0)
            {
                Console.WriteLine($"COSTO MEDIA PER DITTA: {ditteProduttrici[i].Nome}:{media:F2}");
            }
            else
            {
                Console.WriteLine($"COSTO MEDIA PER DITTA: {ditteProduttrici[i].Nome}: nessun videogioco registrato.");
            }
        }
    }
}

