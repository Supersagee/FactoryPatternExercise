using System;

namespace FactoryPatternExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var userVehicle = VehicleFactory.GetVehicle();

            userVehicle.Drive();
        }
    }
}
