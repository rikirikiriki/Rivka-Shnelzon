using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot
{
    class Car
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int EntranceTime { get; set; }
        public int ExitTime { get; set; }
        public int PricePerHour { get; set; }
        public int AmountPaid { get; set; }
        public Car()
        {
            this.ID = new Random().Next(1000, 9999);
            this.Model = "Bugatti Chiron";
            this.Color = "red";
            this.PricePerHour = 150;
        }
        public Car(int entranceTime):this()
        {
            this.EntranceTime = entranceTime;
        }
        public int AmountOwed()
        {
            //int totalTime = this.ExitTime - this.EntranceTime;
            int amountOwed = (this.ExitTime - this.EntranceTime) * this.PricePerHour;
            return amountOwed;
        }
        public int GiveChange()
        {
            int change = this.AmountPaid - AmountOwed();
            return change;
        }
        public static void CarEnter(Car[]pl)
        {
            for (int i = 0; i < pl.Length; i++)
            {
                pl[i] = pl[i] ?? new Car(new Random().Next(0, 23));//how do I know if full?
            }
        }
        public static void CarExit(Car[]pl)
        {
            int index = new Random().Next(0, pl.Length);
            Console.WriteLine($"The car in lot {index} wants to leave.");
            Console.WriteLine($"Entrance time is {pl[index].EntranceTime}");
            Console.WriteLine("Enter exit time:");
            pl[index].ExitTime = int.Parse(Console.ReadLine());
            Console.WriteLine($"You owe ${pl[index].AmountOwed()}.");
            Console.WriteLine("Enter amount:");
            pl[index].AmountPaid = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your change is ${pl[index].GiveChange()}");
            pl[index] = null;
        }
    }
}
