﻿using _4Point1_EF.Models;
using System;
using System.Linq;

namespace _4Point1_EF
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize our database interaction (the context):
            using (CarsContext context = new CarsContext())
            {
                Console.WriteLine(context.Cars.Count(x => x.Manufacturer.Name == "BMW"));

                Console.WriteLine(context.Cars.Count(x => x.Manufacturer.Name == "Mitsubishi"));
            }

        }
    }
}
