using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Models.Entities
{  [Table("OrderDetails")]
   public class OrderDetail
    {
        [Key]
        [Column(Order =1)]
        public int OrderId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int PackageId { get; set; }

        public DateTime OrderDateTime { get; set; }

        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }

        [ForeignKey("PackageId")]
        public virtual Package Package { get; set; }
    }
}
