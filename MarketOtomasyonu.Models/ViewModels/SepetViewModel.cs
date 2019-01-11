using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Models.ViewModels
{
   public  class SepetViewModel
    {
     
        public int ProductId { get; set; }
  
        public int SaleId { get; set; }

        public DateTime SaleDateTime { get; set; } = DateTime.Now;

        public string ProductName { get; set; }

        public decimal SaleAmount { get; set; }

        public int PaymentType { get; set; }

        public decimal ReceivedAmount { get; set; }

        public decimal GivenAmount { get; set; }

        public int Quantity { get; set; }



        public override string ToString() => $"{ProductName} - {Quantity} ";

    }
}
