using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public enum TypeVehicle { Car, FreightCar}

    abstract class Automobile
    {
        private TypeVehicle typeVehicle;
        //расход на 100 км
        private double averageConsumption;

        private double fuelTank;

        private double speed;

        public Automobile(TypeVehicle typeVehicle, double averageConsumption, double fuelTank, double speed)
        {
            this.typeVehicle = typeVehicle;
            this.averageConsumption = averageConsumption;
            this.fuelTank = fuelTank;
            this.speed = speed;
        }

        /// <summary>
        /// Можно вычислить сколько автомобиль может проехать на полном баке топлива или на остаточном количестве топлива в баке на данный момент
        /// </summary>
        /// <returns></returns>
        public double GetMaxPath()
        {
            //возвращаем количество км. сколько можно проехать на текущем баке
            return fuelTank / averageConsumption * 100;
        }

        /// <summary>
        /// Метод для отображения текущей информации о состоянии запаса хода в зависимости от пассажиров и груза.
        /// </summary>
        /// <returns></returns>
        public virtual double GetCondition()
        {
            return fuelTank / averageConsumption * 100;
        }

        /// <summary>
        /// Метод, который на основе параметров количества топлива и заданного расстояния вычисляет за сколько автомобиль его преодолеет.
        /// </summary>
        /// <param name="distance">Рзаданное расстояние</param>
        /// <returns></returns>
        public double GetTime(double distance)
        {
            return distance / speed;
        }
    }
}
