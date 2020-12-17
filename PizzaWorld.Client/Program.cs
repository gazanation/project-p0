using System;
using System.Collections.Generic;
using PizzaWorld.Domain.Models;
using PizzaWorld.Domain.Singletons;

namespace PizzaWorld.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var cs = ClientSingleton.Instance;
            cs.MakeAStore();
            //PrintAllStores();
        }

        static IEnumerable<Store> GetAllStores() //IEnumerable allows you to take any type of collection -- abstraction?
        {
            return new List<Store>()
            {
                new Store(),
                new Store()
            };

           /* var l = new List<Store>();
            l[0] = new Store();
            l.Add(new Store());
            l= new List<Store>()
            {
                new Store()
            };*/
        }

        static void PrintAllStores()
        {
            foreach(var store in GetAllStores())
            {
                Console.WriteLine(store);
            }
        }
    }
}
