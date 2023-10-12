﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    [Table("OrderDetail")]
    public class OrderDetailObject
    {
        [Key]
        [Column(Order = 1)]
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public virtual OrderObject Order { get; set; }
        [Key]
        [Column(Order = 2)]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual ProductObject Product { get; set; }
        [Required]
        public Decimal UnitPrice { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public float Discount { get; set; }
    }
}
