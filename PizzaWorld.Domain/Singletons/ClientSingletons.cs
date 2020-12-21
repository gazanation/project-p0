using System;
using PizzaWorld.Domain.Models;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Linq;

namespace PizzaWorld.Domain.Singletons
{
    public class ClientSingleton
    {
        private const string _path = @"./pizzaworld.xml"; //@ is a literal operator
        private static ClientSingleton _instance;
        
        public static ClientSingleton Instance 
        { 
            get
            {
                if(_instance == null)
                {
                    _instance = new ClientSingleton();
                    
                }
                
                return _instance;
            }

        }

        public List<Store> Stores { get; set; }
        private ClientSingleton()
        {
            Read();  // give collection a place in memory
        }

        public void MakeAStore()
        {
            Stores.Add(new Store());
            Save();
        }

       /* TryParse ex:
       public bool TryParse2(string y, out int x)
        {
            x = 0;
            try
            {
                x = int.Parse(y);
                return true;
            }
            catch
            {
                return false;
            }
        } */

        public Store SelectStore()
        {     
            int.TryParse(Console.ReadLine(), out int input);
            return Stores.ElementAtOrDefault(input);
        }

        private void Save()
        {
          //use serialization -- need a serializer 
            var file = new StreamWriter(_path);
            var xml = new XmlSerializer(typeof(List<Store>));

            xml.Serialize(file, Stores);
            
        }

        private void Read()
        {
            if(File.Exists(_path))
            {
                var file = new StreamReader(_path);
                var xml = new XmlSerializer(typeof(List<Store>));
                Stores = xml.Deserialize(file) as List<Store>; //explicit casting 
                
            }
            else 
            {
                Stores = new List<Store>();
            }
            

            

        }
    }
}