using CodeFirstPractice.Models;
using System;
using System.Linq;

namespace CodeFirstPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Create models and a context for a simple database with the following:
             A table called “Shelves” with:
                 An int primary key called ID.
                 A varchar of length 50 called Name.
             Use Entity Framework to create a database called “code_first_practice” using your models.
             This must be done in a migration.

             Write a program that will take in a shelf name and add it to the database. For example, CreateShelf(“Games Shelf”) or AddShelf(“Movies Shelf”).
             */
            Console.Write("Please enter the name of the shelf to add: ");
            try
            {
                AddShelf(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Shelf Addition Failed: {e.Message}");
            }

        }
        public static void AddShelf(string name)
        {
            using (ShelvesContext context = new ShelvesContext())
            {
                if (context.Shelves.Where(x => x.Name.ToUpper() == name.Trim().ToUpper()).Count() != 0)
                {
                    throw new Exception("That shelf already exists.");
                }
                context.Shelves.Add(new Shelves() { Name = name.Trim() });
                context.SaveChanges();
            }
        }
    }
}
