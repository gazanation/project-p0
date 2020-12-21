using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class Pizza : PizzaModel
    {
        protected override void AddCrust()
        {
            base.AddCrust();
            // Crust = "regular";
        }

        protected override void AddSize()
        {
            base.AddSize();
            //Size = "small";
        }

        protected override void AddToppings()
        {
            base.AddToppings();
            /* Toppings = new List<string>
                {
                    "cheese"
                    "tomato"
                }; */
        }
    }
}
