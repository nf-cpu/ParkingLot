using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ParkingApp.Tests;

public class CarTests
{
    [Fact]
    public void GetColor_ReturnsCarColor()
    {
        var car = new Car("11-111-11", "Lior", "Red");

        var result = car.GetColor();

        Assert.Equal("Red", result);
    }
}
