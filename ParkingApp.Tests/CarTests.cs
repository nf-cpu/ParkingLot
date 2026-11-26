using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp.Tests
{
    public class CarTests
    {
        [Fact]
        public void GetColor_ReturnsCarColor()
        {
            Car car = new Car("1234567", "David", "Red");

            Assert.Equal("Red", car.Getcolor());
        }
    }
}
