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

            //try
            //{
                AddShelf(name, material);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"Shelf Addition Failed: {e.Message}");
            //}

        }
        public static void AddShelf(string name, string materialName)
        {
            name = name.Trim();
            materialName = materialName.Trim();

            using (ShelfContext context = new ShelfContext())
            {
                if (context.Shelves.Where(x => x.Name.ToUpper() == name.ToUpper()).Count() != 0)
                {
                    throw new Exception("That shelf already exists.");
                }
                IQueryable<ShelfMaterial> matchingMaterials = context.ShelfMaterials.Where(x => x.MaterialName.ToUpper() == materialName.ToUpper());
                if (matchingMaterials.Count() == 0)
                {
                    string addResponse;
                    Console.Write("The material doesn't exist, would you like to add it? (Y/N): ");
                    addResponse = Console.ReadLine().Trim().ToUpper();
                    if (addResponse == "Y")
                    {
                        string titleCaseMaterial = "";
                        for (int i = 0; i < materialName.Length; i++)
                        {
                            // If it's the first character in the string, or the character preceding it is a space.
                            if (i == 0 || materialName[i-1] == ' ')
                            {
                                titleCaseMaterial += char.ToUpper(materialName[i]);
                            }
                            else
                            {
                                titleCaseMaterial += char.ToLower(materialName[i]);
                            }
                            
                        }
                        context.ShelfMaterials.Add(new ShelfMaterial()
                        {
                            MaterialName = titleCaseMaterial
                        });

                        // Save the material.
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Material specified does not exist.");
                    }
                }

                context.Shelves.Add(new Shelf() { Name = name.Trim(), Material = matchingMaterials.First() });

                // Save the shelf.
                context.SaveChanges();
            }
        }
    }
}
