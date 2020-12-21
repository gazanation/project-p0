using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Factories;

namespace PizzaWorld.Domain.Models
{
    public class Order
    {
        private GenericPizzaFactory pizzaFactory = new GenericPizzaFactory();

        public List<PizzaModel> Pizzas { get; set; }

        public Order()
        {
            Pizzas = new List<PizzaModel>();
        }

        public void MakePizza()
        {
            Pizzas.Add(pizzaFactory.Make<Pizza>());

        }
        
    }
    
}