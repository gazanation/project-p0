using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Factories
{
    class GenericPizzaFactory
    {
        public P Make<P>() where P : PizzaModel, new()
        {
            return new P();
        }
    }
}