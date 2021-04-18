using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyNewMarket.Dal.Models
{
    [Table("Address")]
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, MaxLength(40)]
        public string StreetAddress { get; set; }
        [Required, MaxLength(40)]
        public string City { get; set; }
        [Required, MaxLength(40)]
        public string province { get; set; }
        [Required, MaxLength(40)]
        public string PostalCode { get; set; }
        [Required, MaxLength(40)]
        public string Country { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

    }
}
