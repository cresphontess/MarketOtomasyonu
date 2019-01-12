using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Models.ViewModels
{
  public  class OrderViewModel
    {
        
        public string PackageName { get; set; }

        public int PackageId { get; set; }

        public string PackageBarcode { get; set; }

        public int PackageProductQuantity { get; set; }

        public int ProductId { get; set; }

        public int ProductStock { get; set; }

        public override string ToString() => $"{PackageName} - ({PackageBarcode})";

    }
}
