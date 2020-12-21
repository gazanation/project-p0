using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaWorld.Domain.Models
{
    public class Customer
    {
        public List<Order> Orders { get; set; }

        public Store SelectedStore { get; set; }

        public Customer()
        {
            Orders = new List<Order>();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach(var p in Orders.Last().Pizzas)
            {
                sb.AppendLine(p.ToString());
            }
            return $"I have selected this store: {SelectedStore} and ordered these pizzas: {sb.ToString()}"; //string interpolation
        }
    }
}