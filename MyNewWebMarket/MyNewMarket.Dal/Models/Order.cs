using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyNewMarket.Dal.Models
{
    [Table("Order")]
    public class Order
    {
        public enum OrderStatus : byte
        {
            Ordered = 0,
            Returned = 1,
            Processing = 2,

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        public DateTime CreateOrderDate { get; set; }
        public DateTime? ModifyOrderDate { get; set; }
        public double TotalAmount { get; set; }
        public short DeliveryStatus { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
    }
}
