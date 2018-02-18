using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata
{
    interface ICheckout
    {
        void Scan(string item);
        int GetTotalPrice();
    }

    public class Checkout : ICheckout
    {
        private readonly List<InventoryItem> _inventory;

        public Checkout(List<InventoryItem> inventory)
        {
            _inventory = inventory;
        }

        public void Scan(string item)
        {
            
        }

        public int GetTotalPrice()
        {
            return _inventory.First(i => i.Sku == "A").Price;
        }
    }
}
