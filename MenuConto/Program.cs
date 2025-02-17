using System;
using MenuConto.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

MenuData menu = new MenuData(); // Crea un'istanza della classe MenuData
List<int> scelte = new List<int>(); // Memorizza gli indici dei prodotti scelti
bool ciclo = true;

while (ciclo)
{
    Console.WriteLine("============= MENU ====================");
    Console.WriteLine("Scegli un'opzione da 1 a 11:");
    Console.WriteLine("1: Coca Cola 150 ml (€ 2.50)");
    Console.WriteLine("2: Insalata di pollo (€ 5.20)");
    Console.WriteLine("3: Pizza Margherita (€ 10.00)");
    Console.WriteLine("4: Pizza 4 Formaggi (€ 12.50)");
    Console.WriteLine("5: Pz patatine fritte (€ 3.50)");
    Console.WriteLine("6: Insalata di riso (€ 8.00)");
    Console.WriteLine("7: Frutta di stagione (€ 5.00)");
    Console.WriteLine("8: Pizza fritta (€ 5.00)");
    Console.WriteLine("9: Piadina vegetariana (€ 6.00)");
    Console.WriteLine("10: Panino Hamburger (€ 7.90)");
    Console.WriteLine("11: Stampa conto finale e conferma");
    Console.WriteLine("============= MENU ====================");

    string? scelta = Console.ReadLine();

    if (int.TryParse(scelta, out int sceltaNumero))
    {
        if (sceltaNumero >= 1 && sceltaNumero <= 10)
        {
            scelte.Add(sceltaNumero - 1); // Salviamo l'indice dell'elemento scelto
            Console.WriteLine("Prodotto aggiunto al carrello!");
        }
        else if (sceltaNumero == 11)
        {
            // Stampiamo il conto totale
            decimal totale = menu.SumAllMenuPrice(scelte, "n");
            Console.WriteLine($"\nTotale da pagare: € {totale:F2}");
            ciclo = false; // Termina il ciclo
        }
        else
        {
            Console.WriteLine("Scelta non valida. Riprova.");
        }
    }
    else
    {
        Console.WriteLine("Inserisci un numero valido!");
    }
}
