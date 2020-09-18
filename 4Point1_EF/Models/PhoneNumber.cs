﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExistingDBPractice.Models
{
    [Table("phonenumber")]
    public partial class PhoneNumber
    {
        [Key]
        [Column("ID", TypeName = "int(10)")]
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "char(12)")]
        public string Number { get; set; }
        [Column("PersonID", TypeName = "int(10)")]
        public int PersonID { get; set; }

        [ForeignKey(nameof(PersonID))]
        [InverseProperty(nameof(Models.Person.PhoneNumbers))]
        public virtual Person Person { get; set; }
    }
}
