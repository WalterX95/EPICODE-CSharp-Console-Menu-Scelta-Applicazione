using System;
using System.Collections.Generic;
using System.Linq;

namespace MenuConto.Models
{
    internal class MenuData
    {
        private List<string> Menu = new List<string>();
        private List<decimal> MenuPrice = new List<decimal>();
        private string? MenuName { get; set; }
        private List<decimal> PriceChoose = new List<decimal>();

        public string AddMenuData(string dataName)
        {
            Menu.Add(dataName);
            return dataName;
        }

        public decimal AddMenuData(decimal pricesName)
        {
            MenuPrice.Add(pricesName);
            return pricesName;
        }

        public string ReturnAllMenu()
        {
            string[] voiceMenu = {
                "1: Coca Cola 150 ml (€ 2.50)",
                "2: Insalata di pollo (€ 5.20)",
                "3: Pizza Margherita (€ 10.00)",
                "4: Pizza 4 Formaggi (€ 12.50)",
                "5: Pz patatine fritte (€ 3.50)",
                "6: Insalata di riso (€ 8.00)",
                "7: Frutta di stagione (€ 5.00)",
                "8: Pizza fritta (€ 5.00)",
                "9: Piadina vegetariana (€ 6.00)",
                "10: Panino Hamburger (€ 7.90)"
            };

            decimal[] prices = { 2.50m, 5.20m, 10.00m, 12.50m, 3.50m, 8.00m, 5.00m, 5.00m, 6.00m, 7.90m };

            foreach (decimal price in prices) { AddMenuData(price); }
            foreach (var item in voiceMenu)
            {
                AddMenuData(item);
                Console.WriteLine(item);
            }

            return "";
        }

        public decimal SumAllMenuPrice(List<int> chosenItems, string yesOrNot)
        {
            bool chooseNext = true;
            decimal sum = 0;

            while (chooseNext)
            {
                if (yesOrNot.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Scegli un altro Prodotto");
                    ReturnAllMenu(); // Mostra il menu completo
                    // Logica per chiedere nuovamente la scelta, supponiamo che l'utente inserisca un indice
                    Console.WriteLine("Inserisci il numero dell'elemento che vuoi aggiungere: ");
                    if (int.TryParse(Console.ReadLine(), out int selected))
                    {
                        // Aggiungi il prezzo dell'elemento selezionato
                        if (selected >= 1 && selected <= MenuPrice.Count)
                        {
                            chosenItems.Add(selected - 1); // Aggiungi l'indice selezionato
                            sum += MenuPrice[selected - 1];
                        }
                    }
                }
                else
                {
                    chooseNext = false;
                    Console.WriteLine($"Totale: € {sum:F2}");
                }
            }

            return sum;
        }
    }
}
