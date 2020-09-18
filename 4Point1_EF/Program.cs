using ExistingDBPractice.Models;
using System;
using System.Collections.Generic;
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

            string firstName = "", lastName = null;
            List<string> phoneNumbers = new List<string>();

            

            using (PersonContext context = new PersonContext())
            {
                // Using the null-coalescer we can fix the returning of null from SingleOrDefault and replace the null with a new Person to read the property from.
                // This stops a NullReferenceException from being thrown.

                while (lastName == null && firstName.ToLower() != "quit")
                {
                    Console.Write("Please enter a first name or quit to exit: ");
                    // If we have ToUpper() here, our output will be in uppercase.
                    firstName = Console.ReadLine().Trim();

                    lastName = (context.People.Where(x => x.FirstName.ToUpper() == firstName.ToUpper()).SingleOrDefault() ?? new Person()).LastName;

                    if (lastName == null && firstName.ToLower() != "quit")
                    {
                        Console.WriteLine("That name does not exist in the database, please try again.");
                    }
                    else
                    {
                  
                        phoneNumbers = 
                            // Grab the context.
                            context
                            // Select all the phone numbers.
                            .PhoneNumbers
                            // Filter to only the numbers that have a person whose first name is what we asked for.
                            .Where(x => x.Person.FirstName.ToUpper() == firstName.ToUpper())
                            // Select the actual numbers.
                            .Select(x => x.Number)
                            // Convert to list.
                            .ToList();
            

                        
                        /*
                        // var test = context.PhoneNumbers;
                        // This one didn't work because we haven't directly called the PhoneNumbers table on the context, so it didn't fetch the data.
                        // Therefore it treats the navigation properties pointing to that table as empty.
                        // So either call the target table on the context as the first operation, or do something less efficient like I did in the comment above.
                        phoneNumbers = 
                            // Grab the context.
                            context
                            // Select all the people.
                            .People
                            // Filter the people to only the one we want.
                            .Where(x => x.FirstName.ToUpper() == firstName.ToUpper())
                            // Collapse the list into the single person.
                            .SingleOrDefault()
                            // Get that person's phone numbers.
                            .PhoneNumbers
                            // Select the actual numbers from the objects.
                            .Select(x => x.Number)
                            // Convert it to a List from an IEnumerable.
                            .ToList();
                        */
                        
                    }
                }

                
            }

            if (lastName != null)
            {
                Console.WriteLine($"Full Name: {firstName} {lastName}");
                foreach (string number in phoneNumbers)
                {
                    Console.WriteLine($"Phone Number: {number}");
                }
            }
        }
    }
}
