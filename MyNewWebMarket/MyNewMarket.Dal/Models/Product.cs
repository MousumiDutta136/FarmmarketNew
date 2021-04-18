using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyNewMarket.Dal.Models
{
    [Table("Product")]
    public class Product
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, MaxLength(40)]
        public string ProductName { get; set; }
        [Required, MaxLength(80)]
        public string ProductDetails { get; set; }
        public DateTime CreateProductDate { get; set; }
        public DateTime? ModifyProductDate { get; set; }
        public double ProductQuantity { get; set; }
        //public double Unit { get; set; }
        [MaxLength(40)]
        public string Unit { get; set; }
        public double TotalPrice { get; set; }
        [ForeignKey("Category")]
        public int Categoryid { get; set; }
        public Category Category { get; set; }
        public List<ProductSupplier> ProductSuppliers { get; set; }
    }
}
