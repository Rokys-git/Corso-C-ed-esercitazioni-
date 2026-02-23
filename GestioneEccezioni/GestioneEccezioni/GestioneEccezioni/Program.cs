internal class Program
{
    private static void Main(string[] args)
    {
        //Creazione con inizializzazione rapida
        Dictionary<string, string> regioni = new()
    {
        { "Lombardia", "Milano" },
        { "Liguria", "Genova"},
        { "Piemonte", "Torino"}
    };

        // Esempio: auggiunge una coppia (Add lacia se esite già)
        try
        {
            regioni.Add("Veneto", "Venezia");
            Console.WriteLine("Aggiunta -> Venezia");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Errore: la chiave esiste già", ex.Message);
        }


        // Esempio: usa l'indicazzione per sovrascrivere / impostare
        regioni["Veneto"] = "Palermo"; // Qui sovrascrive o aggiunge senza eccezione
        Console.WriteLine("Impostato veneto -> palermo tramite indicazione");

        // Esempio che gestisce KeyNotFoundException se la chiave non esiste!
        try
        {
            // se "sardegna" non esiste, questo lancerebbe KeyNotFoundException
            string capoluogo = regioni["Serdegna"];
            Console.WriteLine($"Capoluogo serdegna {capoluogo}");
        }
        catch (KeyNotFoundException knf)
        {
            Console.WriteLine($"Chiave non trovata: {knf.Message}");
        }

        // Metodo consigliato: TryGetValue (non lancia eccezioni)
        if (regioni.TryGetValue("Veneto", out string capoLuogo))
        {
            Console.WriteLine("Capoluogo del Veneto (TryGetValue): " + capoLuogo);
        }
        else
        {
            Console.WriteLine("Veneto non presente (TryGetValue).");
        }

        // Mimozione sicuro
        if (regioni.Remove("Piemonte"))
        {
            Console.WriteLine("Piemonte rimosso correttamente🎉");
        }
        else
        {
            Console.WriteLine("Piemonte non era presente");
        }

        // Pulire il dizionario
        regioni.Clear();

        //try
        //{
        // // codice che potrebbe generare eccezioni
        //}
        //catch (IndexOutOfRangeException)
        //{
        //    // Codice per gestire l'eccezione
        //    Console.WriteLine("Errore fuori del range");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine($"Errore generico: {ex.Message}");
        //}
        //finally
        //{
        //    // Codice che viene eseguito sempre, indipendentemente dal fatto che si sia verificata un'eccezione o meno
        //    Console.WriteLine("Blocco finally eseguito.");
        //}

    }

    // Esercizio: scrivi un metodo GetOrDefault(Dictionay<string, string> d, string key, string defaultVal)
    // che ritorna il valore se presente, almenti defaultVal.
    static string GetOrDefault(Dictionary<string, string> d, string key, string defaultVal)
    {
        // (?:) 
        //return condizione ? espressione_se_vera : espressione_se_falso
        return d.TryGetValue(key, out string val) ? val : defaultVal;

        CondizioneIf();
    }

    private static void CondizioneIf()
    {
        int numero = 10;
        string messaggio = (numero > 5) ? "Maggiore di 5" : "Minore o uguale a 5";
        Console.WriteLine(messaggio);
        if (numero > 5)
        {
            messaggio = "Maggiore di 5";
        }
        else
        {
            messaggio = "Minore o uguale a 5";
        }


        int x = 10;
        string risultato = (x > 5) ? "Positivo" :
                           (x < 10) ? "Minore" :
                           "Zero";

    }
}

