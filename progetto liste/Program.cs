
// Gestione di Numeri e Nomi con Array Liste

#region Dichiarazioni e Inizializzazioni
// Dichiarazione di un array di stringhe
string[] nomi = { "Marco", "Cogoni", "Lorenzo", "Giuseppe", "Rocco", "Ruben", "Francesco", "Moussa" };

// Dichiarazione di un array di numeri interi
int[] voti = { 10, 20, 30, 40, 10, 32, 25, 66 };
int somma = 0;
#endregion


// Stampa dei nomi
Console.WriteLine("Elenco dei nomi:");
for (int i = 0; i < nomi.Length; i++)
{
    Console.WriteLine($" {nomi[i]} + {voti[i]}"); // aseegnare i voti a finaco dei nomi
   
}

// Mostra il numero totale di elementi nell'array dei nomi
Console.WriteLine($"\nNumero totale di nomi: {nomi.Length}");

// Calcolo della di tutti i voti
for (int voto = 0; voto < voti.Length; voto++)
{
    somma += voti[voto];
}

// Calcola la media 
double media = (double)somma / voti.Length;

Console.WriteLine($"Media dei voti: {media}");
