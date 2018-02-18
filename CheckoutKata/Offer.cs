using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata
{
    public class Offer
    {
        public string Sku { get; set; }
        public int AmountNeeded { get; set; }
        public int Price { get; set; }

        public Offer(string sku, int amountNeeded, int price)
        {
            Sku = sku;
            AmountNeeded = amountNeeded;
            Price = price;
        }
    }
}
