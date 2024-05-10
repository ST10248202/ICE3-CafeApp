using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeApp
{
    internal class CafeManager
    {
        private Dictionary<string, double> menu = new Dictionary<string, double>()
        {
            {"Coffee", 2.50},
            {"Tea", 2.00},
            {"Sandwich", 5.00},
            {"Cake", 3.50}
        };

        private List<string> orderItems = new List<string>();
        private List<int> orderQuantities = new List<int>();

        public Dictionary<string, double> Menu => menu;

        public List<string> OrderItems => orderItems;

        public List<int> OrderQuantities => orderQuantities;

        public void AddToOrder(string item, int quantity)
        {
            orderItems.Add(item);
            orderQuantities.Add(quantity);
        }

        public string GenerateReceipt()
        {
            double total = 0;

            string receipt = "Receipt:\n";

            for (int i = 0; i < orderItems.Count; i++)
            {
                double price = menu[orderItems[i]];
                int quantity = orderQuantities[i];
                double subtotal = price * quantity;

                receipt += $"{orderItems[i]} x{quantity}: R{price} each, Total: R{subtotal}\n";

                total += subtotal;
            }

            receipt += $"Overall Total: R{total}";

            return receipt;
        }
    }
}
