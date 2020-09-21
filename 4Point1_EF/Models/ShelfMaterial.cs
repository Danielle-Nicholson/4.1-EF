using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CodeFirstPractice.Models
{
    [Table("shelfmaterial")]
    public partial class ShelfMaterial
    {
        // Initialize the navigation property.
        public ShelfMaterial()
        {
            Shelves = new HashSet<Shelf>();
        }

        [Key]
        [Column("id", TypeName = "int(10)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [Column("name", TypeName = "varchar(25)")]
        public string MaterialName { get; set; }


        // This property represents a list of all the related entities which have this entity's primary key as their foreign key. It saves using LINQ to try and filter on the primary key and makes things more readable.
        [InverseProperty(nameof(Models.Shelf.Material))]
        public virtual ICollection<Shelf> Shelves { get; set; }
    }
}
