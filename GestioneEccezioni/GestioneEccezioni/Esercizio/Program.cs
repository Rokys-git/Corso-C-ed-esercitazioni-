namespace Esercizo
{
    /// <summary>
    /// 1. Esercizio: Crea un programma che legge da console una chiave e stampa il valore o "chiave non trovata" senza usare try/catch.
    /// Soluzione: usare ContainsKey o TryGetValue.
    /// 
    /// 2. Esercizio avanzato: Gestisci il caso in cui l’utente tenta di Add una chiave già esistente, mostrando un messaggio e chiedendo se vuole sovrascrivere.
    /// Soluzione: prima ContainsKey, poi chiedere input e usare l’indicizzatore per sovrascrivere.
    /// </summary>
    class program
    {

        static void Main(string[] args)
        {
            Dictionary<string, string> regioni = new()
            {
                { "Lombardia", "Milano" },
                { "Liguria", "Genova"},
                { "Piemonte", "Torino"}
            };

            // Input dell'utente 
            //Console.WriteLine();
            //string input = ........ToLower();

            // Gestire tutto con try{}
            // catch(KeyNotFoundException){}
            // catch (Exception ex){}
            //finally
            //{
            //    // Codice che viene eseguito sempre, indipendentemente dal fatto che si sia verificata un'eccezione o meno
            //    Console.WriteLine("Blocco finally eseguito.");
            //}
        }
    }
}