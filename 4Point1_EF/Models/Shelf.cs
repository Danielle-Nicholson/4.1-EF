using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CodeFirstPractice.Models
{
    [Table("shelf")]
    public partial class Shelf
    {
        [Key]
        [Column("id", TypeName = "int(10)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Column("material_id", TypeName = "int(10)")]
        public int MaterialID { get; set; }

        [Required]
        [Column("name", TypeName = "varchar(50)")]
        public string Name { get; set; }


        // Points to the property representing the foreign key column.
        [ForeignKey(nameof(MaterialID))]
        // By using nameof() it saves us from breaking it accidentally by renaming things, as long as we use Ctrl+R+R to rename them. For some reason the migration from an existing database doesn't use this, which is why things breaks
        [InverseProperty(nameof(Models.ShelfMaterial.Shelves))]
        public virtual ShelfMaterial Material { get; set; }
    }
}
