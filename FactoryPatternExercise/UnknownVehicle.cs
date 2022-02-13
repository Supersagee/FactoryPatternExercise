using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    public class UnknownVehicle : IVehicle
    {

        void IVehicle.Drive()
        {
            Console.WriteLine("I don't know what you are driving!");
        }

    }
}
