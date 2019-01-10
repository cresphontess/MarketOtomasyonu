using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Models.ViewModels
{
   public class PackageViewModel
    {

        public int OrderId { get; set; }
        public string PackageName { get; set; }

        public string PackageBarcode { get; set; }

        public int PackageProductQuantity { get; set; }


        public DateTime OrderProductDateTime { get; set; } = DateTime.Now;


     


        public override string ToString() => $"{PackageName} - ({PackageName})   {PackageProductQuantity}";
    }
}
