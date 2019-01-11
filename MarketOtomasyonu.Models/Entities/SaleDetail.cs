using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Models.Entities
{

    [Table("SaleDetails")]
   public class SaleDetail
    {
        [Key]
        [Column(Order =1)]
        public int ProductId { get; set; }
        [Column(Order = 2)]
        [Key]
        public int SaleId { get; set; }

        public DateTime SaleDateTime { get; set; } = DateTime.Now;

        public decimal SaleAmount { get; set; }

        public int PaymentType { get; set; }

        public decimal  ReceivedAmount { get; set; }

        public decimal GivenAmount { get; set; }


        [ForeignKey("SaleId")]
        public virtual Sale Sale { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
