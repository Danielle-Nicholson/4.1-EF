using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace _4Point1_EF.Models
{
    [Table("manufacturer")]
    public partial class Manufacturer
    {
        [Key]
        [Column("id", TypeName = "int(10)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [Column("name", TypeName = "varchar(30)")]
        public string Name { get; set; }
        [Column("year_founded", TypeName = "int(10)")]
        public int? YearFounded { get; set; }


    }
}
