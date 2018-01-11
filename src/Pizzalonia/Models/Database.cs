using System.Collections.Generic;

namespace Pizzalonia.Models
{
    public class Database
    {
        public IList<Pizza> Menu =
            new[]
            {
                new Pizza("Margherita", Crust.Thin,
                    new[]
                    {
                        new Topping("Tomato", 0.5m),
                        new Topping("Mozzarella", 0.5m),
                    }),
                new Pizza("Pepperoni", Crust.Thin,
                    new[]
                    {
                        new Topping("Tomato", 0.5m),
                        new Topping("Mozzarella", 0.5m),
                        new Topping("Pepperoni", 1.0m),
                    }),
                new Pizza("Olive", Crust.Thin,
                    new[]
                    {
                        new Topping("Tomato", 0.5m),
                        new Topping("Mozzarella", 0.5m),
                        new Topping("Olives", 0.5m),
                    }),
                new Pizza("Funghi", Crust.Thin,
                    new[]
                    {
                        new Topping("Tomato", 0.5m),
                        new Topping("Mozzarella", 0.5m),
                        new Topping("Mushrooms", 0.5m),
                    }),
            };
    }
}
