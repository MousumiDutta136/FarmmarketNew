using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyNewMarket.Dal.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, MaxLength(40)]
        public string FirstName { get; set; }
        [Required, MaxLength(40)]
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Required, MaxLength(40)]
        public string PhoneNumber { get; set; }
        [Required, MaxLength(40)]
        public string Emailaddress { get; set; }
        public User User { get; set; }
    }
}
