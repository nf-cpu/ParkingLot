using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp.Tests
{
    public class ParkingLotTests
    {
        [Fact]
        public void NewLot_HasTwoFreeSpots()
        {
            var lot = new ParkingLot();

            var result = lot.CountFreeSpots();

            Assert.Equal(2, result);
        }
        [Fact]
        public void ParkCar_UsesTheLastFreeSpot()
        {
            var lot = new ParkingLot();
            lot.ParkCar("11-111-11", "Lior");

            var result = lot.ParkCar("22-222-22", "Tal");

            Assert.Equal(5, result);
        }
    }
}