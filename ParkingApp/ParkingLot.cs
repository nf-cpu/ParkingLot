using System;

namespace ParkingApp
{
    public class ParkingLot
    {
        private Car[] spots = new Car[5];
        private int hourlyRate = 10;

        public ParkingLot()
        {
            spots[0] = new Car("12-345-67", "Dana" , "Red");
            spots[1] = new Car("23-456-78", "Noa" , "Black");
            spots[3] = new Car("34-567-89", "Maya" , "White");
        }

        public void DisplaySpots()
        {
            for (int index = 0; index < spots.Length; index++)
            {
                if (spots[index] == null)
                {
                    Console.WriteLine("Spot " + (index + 1) + ": Free");
                }
                else
                {
                    Console.WriteLine("Spot " + (index + 1) + ": " + spots[index].GetPlate() + " (" + spots[index].GetOwner() + ", " + spots[index].GetColor() + ")");
                }
            }
        }

        public int CountFreeSpots()
        {
            int count = 0;

            for (int index = 0; index < spots.Length; index++)
            {
                if (spots[index] == null)
                {
                    count++;
                }
            }

            return count;
        }

        public Car GetCar(int spotNumber)
        {
            int index = spotNumber - 1;

            if (index < 0 || index >= spots.Length)
            {
                return null;
            }

            return spots[index];
        }

        // Returns the spot number, or -1 when the lot is full.
        public int ParkCar(string plate, string owner , string color)
        {
            for (int index = 0; index < spots.Length + 1; index++)
            {
                if (spots[index] == null)
                {
                    spots[index] = new Car(plate, owner , color);
                    return index + 1;
                }
            }

            return -1;
        }

        // Returns the spot number, or -1 when the plate is not found.
        public int FindCar(string plate)
        {
            for (int index = 0; index < spots.Length; index++)
            {
                if (spots[index] != null && spots[index].GetPlate() == plate)
                {
                    return index + 1;
                }
            }

            return -1;
        }

        // Returns the fee, or -1 when there is no car to remove.
        public double RemoveCar(int spotNumber, int minutes)
        {
            int index = spotNumber - 1;

            if (index < 0 || index >= spots.Length || spots[index] == null)
            {
                return -1;
            }

            Car car = spots[index];
            Console.WriteLine("Car " + car.GetPlate() + " is leaving spot " + spotNumber + ".");

            double fee = CalculateFee(minutes);
            spots[index] = null;
            return fee;
        }

        public double CalculateFee(double minutes)
        {
            double hours = Math.Ceiling(minutes / 60);
            return hours * hourlyRate;
        }
    }
}
