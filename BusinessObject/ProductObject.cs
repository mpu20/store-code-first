using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    [Table("Product")]
    public class ProductObject
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(40)]
        public string ProductName { get; set; }
        [Required]
        [MaxLength(20)]
        public string Weight { get; set; }
        [Required]
        [Column(TypeName = "money")]
        public Decimal UnitPrice { get; set; }
        [Required]
        public int UnitsInStock { get; set; }
    }
}
