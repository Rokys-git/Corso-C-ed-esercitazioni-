namespace GestioneStudenti
{
    /// <summary>
    /// 🧮 PROGETTO COMPLETO: “Gestione Studenti con Metodi”
    /// Questo programma:
    /// memorizza studenti e voti
    /// mostra i dati
    /// calcola la media
    /// trova il voto massimo e minimo
    /// 👉 Tutto organizzato con metodi separati per ogni funzione.
    /// </summary>
    class Program
    {
        // Liste Globali (Visibili da tutti i metodi)
        static List<string> nomi = new() { "Marco", "Lorenzo", "Ruben", "Giuseppe", "Norberto", "Di Donni", "Michele", "Simona" };
        static List<int> voti = new() { 28, 30, 25, 18, 22, 27, 30, 24 };

        /// <summary>
        /// Stampa il menu e gestisce le scelte dell'utente
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string scelta;

            do
            {
                MostraMenu();
                scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1": MostraStudenti(); break;
                    case "2": AggiungiStudente(); break;
                    case "3": CalcolaStatiche(); break;
                    case "0": Console.WriteLine("👋 Uscita del programma..."); break;

                    default: Console.WriteLine("❌ Scelta non valida, riprova."); break;

                }
            } while (scelta != "0");
        }

        #region METODI
        // Metodo 1: Mostra il menu principale
        static void MostraMenu()
        {
            Console.WriteLine("\n📚 MENU GESTIONE STUDENTE 📚");
            Console.WriteLine("1) Mostra elemento studenti e voti");
            Console.WriteLine("2) Aggiungi studente");
            Console.WriteLine("3) Calcola madia, Voto massino e minimo");
            Console.WriteLine("0) Esci");
            Console.Write("👉 Seleziona un'opzione: ");
        }

        // Metodo 2: Mostra la lista degli studenti
        static void MostraStudenti()
        {
            Console.WriteLine("\n👩‍🎓👨‍🎓 Elenco degli studenti:");
            for (int item = 0; item < nomi.Count; item++)
            {
                Console.WriteLine($"{item + 1} {nomi[item]} => {voti[item]} punti");
            }
        }

        // Metodo 3: Aggiungi uno studente
        static void AggiungiStudente()
        {
            Console.Write("\nInserisci nome dello studente: ");
            string? nome = Console.ReadLine();

            Console.Write("Inserire Voto: ");
            int voto = Convert.ToInt32(Console.ReadLine());

            nomi.Add(nome!);
            voti.Add(voto);

            Console.WriteLine("✅ Studente aggiunto con successo!");
        }

        // Metodo 4: Calcola la media, voto massimo e minimo
        static void CalcolaStatiche()
        {
            int somma = 0;
            int max = voti[0];
            int min = voti[0];
            string studenteMax = nomi[0];
            string studenteMin = nomi[0];


            for (int i = 0; i < voti.Count; i++)
            {
                //somma = somma + voti[i];
                somma += voti[i];

                // Verifica il voto massimo con if
                if (voti[i] > max)
                {
                    max = voti[i];
                    studenteMax = nomi[i];
                }

                // Verifica il voto minimo con if
                if (voti[i] < min)
                {
                    min = voti[i];
                    studenteMin = nomi[i];
                }

                double media = (double)somma / voti.Count;
                Console.WriteLine($"\n📊 Media voti: {media:F2}");
                Console.WriteLine($"👨‍🎓Studente con il voto massimo è: {studenteMax} e ha ottenuto {max} punti");
                Console.WriteLine($"👩‍🎓 Studente con il voto minimo è {studenteMin} e ha ottenuto {min} punti\n");
            }
        }
        #endregion
    }
}