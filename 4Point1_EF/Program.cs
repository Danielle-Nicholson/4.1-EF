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
            A parameter for “shelfMaterial”
                Ensure the material exists in the “ShelfMaterial” table
                if material does not exist, let the user know and exit.
                “shelfMaterial” parameter should be case insensitive.
                “shelfMaterial” parameter should be trimmed.
                When you add the new shelf, ensure the foreign key for “ShelfMaterial” is populated correctly.

             */
            string name, material;

            Console.Write("Please enter the name of the shelf to add: ");
            name = Console.ReadLine();

            Console.Write("Please enter the name of the shelf material: ");
            material = Console.ReadLine();

            try
            {
                AddShelf(name, material);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Shelf Addition Failed: {e.Message}");
            }

        }
        public static void AddShelf(string name, string materialName)
        {
            using (ShelfContext context = new ShelfContext())
            {
                if (context.Shelves.Where(x => x.Name.ToUpper() == name.Trim().ToUpper()).Count() != 0)
                {
                    throw new Exception("That shelf already exists.");
                }
                IQueryable<ShelfMaterial> matchingMaterials = context.ShelfMaterials.Where(x => x.MaterialName.ToUpper() == materialName.Trim().ToUpper());
                if (matchingMaterials.Count() == 0)
                {
                    throw new Exception("That material does not exist.");
                }

                context.Shelves.Add(new Shelf() { Name = name.Trim(), Material = matchingMaterials.First() });

                context.SaveChanges();
            }
        }
    }
}
