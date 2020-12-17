using PizzaWorld.Domain.Models;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace PizzaWorld.Domain.Singletons
{
    public class ClientSingleton
    {
        private static ClientSingleton _instance;
        public static ClientSingleton Instance 
        { 
            get
            {
                if(_instance != null)
                {
                    _instance = new ClientSingleton();
                    
                }
                
                return _instance;
            }

        }

        public List<Store> Stores { get; set; }
        private ClientSingleton()
        {
            Stores = new List<Store>();  // give collection a place in memory
        }

        public void GetAllStores()
        {

        }

        public void MakeAStore()
        {
            var s = new Store();
            Stores.Add(s);
            Save();
        }

        private void Save()
        {
            string path = @"./pizzaworld.xml"; //use serialization need a serializer next line
            var file = new StreamWriter(path);
            var xml = new XmlSerializer(typeof(List<Store>));

            xml.Serialize(file, Stores);
            
        }
    }
}