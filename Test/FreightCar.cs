using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class FreightCar : Automobile
    {
        private double maxLoadCapacity;
        private double loadCapacity;

        public double LoadCapacity
        {
            get => loadCapacity; 
            set
            {
                if (value > maxLoadCapacity)
                {
                    Console.WriteLine("Превышение объема груза");
                    loadCapacity = value;
                }
                else loadCapacity = value;
            }
        }

        public FreightCar(TypeVehicle typeVehicle, double averageConsumption, double fuelTank, double speed, double maxLoadCapacity) : base(typeVehicle, averageConsumption, fuelTank, speed)
        {
            this.maxLoadCapacity = maxLoadCapacity;
            loadCapacity = 0;
        }

        public override double GetCondition()
        {
            if (loadCapacity <= maxLoadCapacity)
                return base.GetCondition();
            else
            {
                return base.GetCondition() * (1 - ((loadCapacity - maxLoadCapacity) / 200) * 0.04);
            }
        }
    }
}
