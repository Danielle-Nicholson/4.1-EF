﻿using _4Point1_EF.Models;
using _4Point1_EF.Controllers;
using System;
using System.Linq;

namespace _4Point1_EF
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Location
                    -Name
                    -Address
                    -PostalCode
                    -City
                Employee
                    -FirstName
                    -LastName
                    -BirthDate
                    -HireDate
                    -EndDate
            */

            // In class practice: Add a method to the EmployeeController that will get an employee by their ID.

            string name;
            string location;

            Console.Write("Please enter a Full Name: ");
            name = Console.ReadLine().Trim().ToUpper();

            EmployeeController employeeController = new EmployeeController();
            Employee target = employeeController.GetEmployee(name.Split(' ')[0], name.Split(' ')[1]);

            LocationController locationController = new LocationController();
            Location work = locationController.GetLocationFromEmployee(target.ID);

            Console.WriteLine($"{target.FirstName} {target.LastName} works at {work.Name} - {work.Address} {work.PostalCode}, {work.City}.");


            
        }
    }
}
