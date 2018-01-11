namespace Pizzalonia.Models
{
    public class Topping
    {
        public Topping(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; }
        public decimal Price { get; }
    }
}
