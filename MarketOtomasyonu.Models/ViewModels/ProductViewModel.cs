using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Models.ViewModels
{
   public  class ProductViewModel
    {

 
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductBarcode { get; set; }
        public int ProductStock { get; set; }   
        public decimal ProductPurchasingPrice { get; set; }    
        public decimal ProductSellingPrice { get; set; }
        public int CategoryId { get; set; }



        public int PackageId { get; set; }

        public string PackageName { get; set; }
 
        public string PackageBarcode { get; set; }

        public decimal PackagePurchasingPrice { get; set; }

        public int PackageProductQuantity { get; set; }
    }
}
