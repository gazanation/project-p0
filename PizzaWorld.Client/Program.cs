using System;
using System.Collections.Generic;
using PizzaWorld.Domain.Models;
using PizzaWorld.Domain.Singletons;
using System.Linq;


namespace PizzaWorld.Client
{
    class Program
    {
        private static readonly ClientSingleton _client = ClientSingleton.Instance;
        

        static void Main(string[] args)
        {   
            _client.MakeAStore();
            CustomerView();

        }


        static void PrintAllStores()
        {
            foreach(var store in _client.Stores)
            {
                Console.WriteLine(store);
            }
        }

        static void CustomerView()
        {
            var customer = new Customer();

            PrintAllStores();
            _client.SelectStore();

            customer.SelectedStore = _client.SelectStore();
            customer.SelectedStore.CreateOrder();
            customer.Orders.Add(customer.SelectedStore.Orders.Last());
            customer.Orders.Last().MakePizza();
            customer.Orders.Last().MakePizza();

            Console.WriteLine(customer);
        }
    }
}
