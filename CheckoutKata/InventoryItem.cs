namespace CheckoutKata
{
    public class InventoryItem
    {
        public string Sku { get; set; }
        public int Price { get; set; }

        public InventoryItem(string sku, int price)
        {
            Sku = sku;
            Price = price;
        }
    }
}