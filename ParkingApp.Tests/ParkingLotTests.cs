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
            lot.ParkCar("11-111-11", "Lior", "white");

            var result = lot.ParkCar("22-222-22", "Tal", "white");

            Assert.Equal(5, result);
        }
        [Theory]
        [InlineData(30, 10)]
        [InlineData(60, 10)]
        [InlineData(61, 20)]
        [InlineData(90, 20)]
        [InlineData(120, 20)]
        public void CalculateFee_ChargesEveryStartedHour(int minutes, int expected)
        {
            var lot = new ParkingLot();

            var result = lot.CalculateFee(minutes);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void RemoveCar_ReturnsMinusOne_WhenSpotIsEmpty()
        {
            var lot = new ParkingLot();

            var result = lot.RemoveCar(3, 60);

            Assert.Equal(-1, result);
        }

        [Fact]
        public void RemoveCar_ClearsSpot_WhenSpotIsOccupied()
        {
            ParkingLot lot = new ParkingLot();


            lot.RemoveCar(1, 30);
            Assert.Null(lot.GetCar(1));
        }
    }
}
