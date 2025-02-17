using System;
using System.Collections.Generic;

namespace MenuConto.Models
{
    internal class MenuData
    {
        private List<string> Menu = new List<string>();
        private List<decimal> MenuPrice = new List<decimal>();

        public MenuData()
        {
            InizializzaMenu();
        }

        private void InizializzaMenu()
        {
            string[] voiceMenu = {
                "Coca Cola 150 ml (€ 2.50)",
                "Insalata di pollo (€ 5.20)",
                "Pizza Margherita (€ 10.00)",
                "Pizza 4 Formaggi (€ 12.50)",
                "Pz patatine fritte (€ 3.50)",
                "Insalata di riso (€ 8.00)",
                "Frutta di stagione (€ 5.00)",
                "Pizza fritta (€ 5.00)",
                "Piadina vegetariana (€ 6.00)",
                "Panino Hamburger (€ 7.90)"
            };

            decimal[] prices = { 2.50m, 5.20m, 10.00m, 12.50m, 3.50m, 8.00m, 5.00m, 5.00m, 6.00m, 7.90m };

            for (int i = 0; i < voiceMenu.Length; i++)
            {
                Menu.Add(voiceMenu[i]);
                MenuPrice.Add(prices[i]);
            }
        }

        public decimal SumAllMenuPrice(List<int> chosenItems)
        {
            decimal sum = 0;
            foreach (int index in chosenItems)
            {
                if (index >= 0 && index < MenuPrice.Count)
                {
                    sum += MenuPrice[index];
                }
            }
            return sum;
        }
    }
}
