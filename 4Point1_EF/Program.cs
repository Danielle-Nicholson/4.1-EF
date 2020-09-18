using ExistingDBPractice.Models;
using System;
using System.Linq;

namespace ExistingDBPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Write a program that will:
                Take in a first name from the user
                Case insensitive
                Trimmed
                Then print the full name of that user from the database
                If the name is not in the database then output “Name not found.” and exit.

            Challenges:
                If the name is not in the database, keep prompting until they enter a name that is, or until they enter “quit” (case insensitive).
                Also print the person’s phone number(s) based on their first name.
                Research Code First Migrations
                    Add an “EmailAddress” table to the models in C#
                    Push the “EmailAddress” table update to the database.
                    Research Data Seeding - EF and add an email address for each person.
                    Push the email addresses in an update to the database.
            */

            string firstName, lastName;

            Console.Write("Please enter a first name: ");
            // If we have ToUpper() here, our output will be in uppercase.
            firstName = Console.ReadLine().Trim();

            using (PersonContext context = new PersonContext())
            {
                // Using the null-coalescer we can fix the returning of null from SingleOrDefault and replace the null with a new Person to read the property from.
                // This stops a NullReferenceException from being thrown.
                lastName = (context.People.Where(x => x.FirstName.ToUpper() == firstName.ToUpper()).SingleOrDefault()??new Person()).LastName;
            }

            Console.WriteLine(lastName != null ? $"Full Name: {firstName} {lastName}" : "Name not found."); 
        }
    }
}
