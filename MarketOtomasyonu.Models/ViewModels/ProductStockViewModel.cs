using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Models.ViewModels
{
    public class ProductStockViewModel
    {

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductBarcode { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPurchasingUnitPrice { get; set; }
        public decimal ProductSellingPrice { get; set; }
        public int CategoryId { get; set; }

        public override string ToString() => $" Ürün Adı {ProductName} - Ürün Adeti {ProductStock}";
    }
}
