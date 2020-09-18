using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ExistingDBPractice.Models
{
    [Table("emailaddress")]
    public partial class EmailAddress
    {
        [Key]
        [Column("ID", TypeName = "int(10)")]
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Email { get; set; }
        [Column("PersonID", TypeName = "int(10)")]
        public int PersonID { get; set; }

        [ForeignKey(nameof(PersonID))]
        [InverseProperty(nameof(Models.Person.Emails))]
        public virtual Person Person { get; set; }
    }
}
