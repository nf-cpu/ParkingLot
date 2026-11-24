using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace ParkingApp.Tests
{
    public class CarTests
    {
        [Fact]
        public void GetColor_ReturnsTheColorTheCarWasCreatedWith()
        {
            var car = new Car("12-345-67", "Luna" ,"Red");

            Assert.Equal("Red", car.GetColor());
        }
    }
}