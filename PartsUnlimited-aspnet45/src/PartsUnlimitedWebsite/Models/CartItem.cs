using System;
using System.ComponentModel.DataAnnotations;
//My first change
//My second change
namespace PartsUnlimited.Models
{
//My first change
    public class CartItem : ILineItem
    {
        //My second change
        [Key]
        public int CartItemId { get; set; }

        [Required]
        public string CartId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; }

        public virtual Product Product { get; set; }
    }
}