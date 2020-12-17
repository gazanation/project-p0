using Xunit;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Testing
{
    internal class OrderTests
    {
        [Fact] // this is an attribute to give additional functionality to the method..

        private void Test_OrderExists()
        {
            // create variable for new object and call method
            //arrange sut - subject under test
            var sut = new Order(); //inference
            

            // act/execute
            var actual = sut;

            //assert
            Assert.IsType<Order>(actual); //checking if this is of this type
            Assert.NotNull(actual); //checking if there is something there - memory space

        }
    }
}
