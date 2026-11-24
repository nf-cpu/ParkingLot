using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp.Tests;

public class ParkingLotTests
{
    [Fact]
    public void NewLot_HasTwoFreeSpots()
    {
        var lot = new ParkingLot();

        var result = lot.CountFreeSpots();

        Assert.Equal(2, result);
    }
}