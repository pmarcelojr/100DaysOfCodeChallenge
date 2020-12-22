using System.Globalization;

namespace _009Day.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        public OrderItem()
        {
        }
        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }
        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return Product.Name + ", $"
                + Price.ToString("f2", CultureInfo.InvariantCulture)
                + ", Quantity: " + Quantity + ", Subtotal: $"
                + SubTotal().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}