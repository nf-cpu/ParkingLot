using System;

namespace ParkingApp
{
    public class Program
    {
        public static void Main()
        {
            ParkingLot lot = new ParkingLot();
            bool isRunning = true;

            while (isRunning)
            {
                ShowMenu();
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        lot.DisplaySpots();
                        break;
                    case "2":
                        ParkCar(lot);
                        break;
                    case "3":
                        FindCar(lot);
                        break;
                    case "4":
                        RemoveCar(lot);
                        break;
                    case "5":
                        isRunning = false;
                        Console.WriteLine("Goodbye.");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

                Console.WriteLine();
            }
        }

        private static void ShowMenu()
        {
            Console.WriteLine("Parking Lot");
            Console.WriteLine("1. Show parking spots");
            Console.WriteLine("2. Park a car");
            Console.WriteLine("3. Find a car by plate");
            Console.WriteLine("4. Remove a car and pay");
            Console.WriteLine("5. Exit");
        }

        private static void ParkCar(ParkingLot lot)
        {
            Console.Write("Enter a plate number: ");
            string plate = Console.ReadLine();
            Console.Write("Enter the owner name: ");
            string owner = Console.ReadLine();
            Console.Write("Enter the color : ");
            string color = Console.ReadLine();
            int spotNumber = lot.ParkCar(plate, owner,color);

            if (spotNumber == -1)
            {
                Console.WriteLine("The parking lot is full.");
            }
            else
            {
                Console.WriteLine("Parked in spot " + spotNumber + ".");
            }
        }

        private static void FindCar(ParkingLot lot)
        {
            Console.Write("Enter a plate number: ");
            string plate = Console.ReadLine();

            int spotNumber = lot.FindCar(plate);

            if (spotNumber == -1)
            {
                Console.WriteLine("Car not found.");
            }
            else
            {
                Console.WriteLine("Car found in spot " + spotNumber + ", owner: " + lot.GetCar(spotNumber).GetOwner());
            }
        }

        private static void RemoveCar(ParkingLot lot)
        {
            Console.Write("Enter a spot number: ");
            int spotNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the parking time in minutes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            int fee = lot.RemoveCar(spotNumber, minutes);

            if (fee == -1)
            {
                Console.WriteLine("There is no car to remove from this spot.");
            }
            else
            {
                Console.WriteLine("Fee: " + fee + " NIS");
            }
        }
    }
}
