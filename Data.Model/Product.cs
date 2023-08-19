using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Product
    {
        [Key]
        public int productId { get; set; }
        [Required]
        [MaxLength(50)]
        public string productName { get; set; }
        [MaxLength(250)]
        public string productDescription { get; set; }
        public int categoryId { get; set; }
        [ForeignKey("categoryId")]
        public Category Category { get; set; }
    }
}
