using System;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            Car[] parkingLot = new Car[size];
            for (int i = 0; i < parkingLot.Length; i++)
            {
               parkingLot[i]= new Car(new Random().Next(0, 23));
            }
            do
            {
                Car.CarExit(parkingLot);
                Car.CarEnter(parkingLot);
            } while (true);
        }
    }
}
