using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    public static class VehicleFactory
    {

        public static IVehicle GetVehicle()
        {
            Console.WriteLine("How many wheels are on your vehicle?");

            var answer = int.Parse(Console.ReadLine());

            switch (answer)
            {
                case 4:
                    return new Car();
                case 2: 
                    return new Motorcycle();
                default:
                    return new UnknownVehicle();
            }
        }

    }
}
