using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Models.Entities
{   [Table("Categories")]
   public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]

        public string CategoryName { get; set; }


        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();

    }
}
