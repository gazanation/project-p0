using System.Collections.Generic;

namespace PizzaWorld.Domain.Models
{
    public class Store
    {
        public List<Order> Orders { get; set; } //getters and setters simply done

        public void CreateOrder()
        {
            //create a new order object based on list
            Orders.Add(new Order());

        }   

        bool DeleteOrder(Order order)
        {
            try
            {
                Orders.Remove(order);           
                return true;
            }
            catch
            {
                return false;
            }
            
        } 
    }
}