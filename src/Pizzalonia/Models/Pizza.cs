using System.Collections.Generic;
using System.Linq;

namespace Pizzalonia.Models
{
    public class Pizza
    {
        public Pizza(string name, Crust crust, IEnumerable<Topping> toppings)
        {
            Name = name;
            Crust = Crust;
            Toppings = toppings.ToList();
        }

        public string Name { get; }
        public Crust Crust { get; }
        public IList<Topping> Toppings { get; }
    }
}
