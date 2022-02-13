﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    public class Car : IVehicle
    {
        void IVehicle.Drive()
        {
            Console.WriteLine("You are driving a car.");
        }
    }
}
