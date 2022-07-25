using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Легковой автомобиль");

            Automobile car = new Car(TypeVehicle.Car, 10, 120, 110, 4);
            Console.WriteLine("Максимальный путь без пассажиров: " + car.GetMaxPath() + " км");
            ((Car)car).NumberPassengers = 3;
            Console.WriteLine("Максимальный путь с пассажирами без перегруза: " + car.GetCondition() + " км");
            ((Car)car).NumberPassengers = 5;
            Console.WriteLine("Максимальный путь с пассажирами с перегрузом: " + car.GetCondition() + " км");
            Console.WriteLine("Время за которое будет пройденно 1000 км: " + car.GetTime(1000) + " ч.");

            Console.WriteLine("Грузовой автомобиль");

            Automobile freightCar = new FreightCar(TypeVehicle.FreightCar, 21, 1200, 80, 12000);

            Console.WriteLine("Максимальный путь без груза: " + freightCar.GetMaxPath() + " км.");
            ((FreightCar)freightCar).LoadCapacity = 10000;
            Console.WriteLine("Максимальный путь с грузом без перегруза: " + freightCar.GetCondition() + " км.");
            ((FreightCar)freightCar).LoadCapacity = 14000;
            Console.WriteLine("Максимальный путь с грузом с перегрузом: " + freightCar.GetCondition() + " км.");
            Console.WriteLine("Время за которое будет пройденно 1000 км: " + freightCar.GetTime(1000) + " ч.");

            Console.Read();
        }
    }
}
