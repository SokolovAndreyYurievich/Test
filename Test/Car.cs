using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Car : Automobile
    {
        private double maxPassengers;
        private double numberPassengers;

        public double NumberPassengers 
        { 
            get => numberPassengers; 
            set 
            { 
                    if (value > maxPassengers)
                    { 
                        numberPassengers = value;
                        Console.WriteLine("Превышение количества пассажиров");
                    }
                    else numberPassengers = value;
            } 
        }

        public Car(TypeVehicle typeVehicle, double averageConsumption, double fuelTank, double speed, double maxPassengers) : base(typeVehicle, averageConsumption, fuelTank, speed)
        {
            this.maxPassengers = maxPassengers;
            this.numberPassengers = 0;
        }

        public override double GetCondition()
        {
            if (maxPassengers >= numberPassengers)
                return base.GetCondition();
            else
            {
                return base.GetCondition() * (1 - (numberPassengers - maxPassengers) * 0.06);
            }         
        }
    }
}
