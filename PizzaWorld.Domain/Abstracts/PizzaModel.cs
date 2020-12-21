using System.Collections.Generic;

namespace PizzaWorld.Domain.Abstracts
{
    public abstract class PizzaModel
    {
        public string Crust { get; set; }
        public string Size { get; set; }
        public List<string> Toppings { get; set; }

        protected PizzaModel()
        {
            AddCrust();
            AddSize();
            AddToppings();
        }

        protected virtual void AddCrust(){}
        protected virtual void AddSize(){}
        protected virtual void AddToppings(){}
    }
}