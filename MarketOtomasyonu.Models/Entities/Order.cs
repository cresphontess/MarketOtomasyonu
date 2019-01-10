using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Models.Entities
{
    [Table("Orders")]
  public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public string OrderName { get; set; }

        public DateTime OrderDateTime { get; set; } = DateTime.Now;

        public virtual ICollection<Package> Packages { get; set; } = new HashSet<Package>();

        public override string ToString()
        {
            return $"{OrderName}";
        }
    }
}
