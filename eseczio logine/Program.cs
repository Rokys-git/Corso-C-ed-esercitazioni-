namespace eserciziologine; 
using System;
class Program
{

    public static void Main(string[] args)
    {

        // imposta il colore del teso su Ciano
        System.Console.ForegroundColor = ConsoleColor.Cyan;


        // stampa il testo decorativo del programma
        Console.WriteLine("┌──────────────────────────────┐");
        Console.WriteLine("│     SISTEMA DI LOGIN v3.0    │");
        Console.WriteLine("└──────────────────────────────┘");

        // riprisitina il colore normale della console 
        Console.ResetColor();


        // -----------------------------------------------
        // Dati di accesso  correnti salvati nel sistema  (database)
        //------------------------------------------------

        string usernamesistem = "Rocco";
        string passwordsistem = "1234@";


        // -----------------------------------------------
        // variabili per gestire i tentativi di logine 
        //------------------------------------------------  

        int tentativi = 0,  tentativiMax =3;
        bool accessoConsentito = false; // indica se l'accesso è stato consentito con successo

        // ciclo di tentativi di login while 
        // Continua fino a quando non si supera il numero massimo di tentativi 
        // o fino a quando l'accesso non è consentito
        while (tentativi < tentativiMax && accessoConsentito == false)
        {
            // colore giallo per l'imput dell'utente
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n 🙍  inserisci il tuo username:");
            string username = Console.ReadLine();
            Console.ResetColor();
            

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n 🔑 inserisci la tua password:");
            string password= Console.ReadLine();
            Console.ResetColor();

            //-----------------------------------------------
            // verifica delle credenziali di accesso if e else 
            //------------------------------------------------

            if ( username == usernamesistem && password == passwordsistem)
            {
                // imposta l'accesso come riuscito 
                accessoConsentito = true;

                // animazione  di verifica  credenziali
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("verifica credenziali");

                // ciclo per animazione caricamento a punti 
                for (int i = 0; i < 5; i++)
                { 
                 Console.Write(".");
                 Thread.Sleep(400);// pausa di 0.4 millisecondi
                }
                Console.ResetColor();

                // messaggio successo
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Accesso consentito! Benvenuto nel sistema.😊");

                // mostra data e ora di accesso
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"🕛Data e ora di accesso: {DateTime.Now}");
                Console.ResetColor();


                // messaggio di benvenuto personalizzato
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Ciao {username}, sei loggato con successo!");
                Console.WriteLine("🔥benevenuto nel sistema");
                Console.ResetColor();
            }
            else
            {
                //incrementa il contatore dei tentativi
                tentativi++;

                // messaggio di errore, dei tentativi rimanenti
                int tentativiRimasti = tentativiMax - tentativi;

                // colore rosso per messaggi di errore
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n Credenziali errate! Accesso negato. XX {tentativiRimasti}" );
                Console.ResetColor();

                // attesa di 4 secondo prima del prossimo tentativo
                Thread.Sleep(400);

            }


        }


    }
}