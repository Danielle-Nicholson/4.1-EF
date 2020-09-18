using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExistingDBPractice.Models
{
    [Table("person")]
    public partial class Person
    {
        public Person()
        {
            PhoneNumbers = new HashSet<PhoneNumber>();
            Emails = new HashSet<EmailAddress>();
        }

        [Key]
        [Column("ID", TypeName = "int(10)")]
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string FirstName { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string LastName { get; set; }

        [InverseProperty(nameof(Models.PhoneNumber.Person))]
        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }

        [InverseProperty(nameof(Models.EmailAddress.Person))]
        public virtual ICollection<EmailAddress> Emails { get; set; }
    }
}
