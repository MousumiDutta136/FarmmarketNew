using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyNewMarket.Dal.Models
{
    [Table("Item")]
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ItemId { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [Required]
        public double ItemQuantity { get; set; }
        public double SubTotal { get; set; }
        [Required]
        public double tax { get; set; }
        public double discount { get; set; }
       
        public double TotalAmount { get; set; }

    }
}
