using MarketOtomasyonu.BLL.Repository;
using MarketOtomasyonu.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.BLL.BLL
{
    public class SaleBusines
    {

        public void MakeOrder(CartViewModel cart)
        {

            var dbDetails = new SaleDetailRepo();


            foreach (var item in cart.CartModel)
            {
                dbDetails.Insert(new SaleDetail()
                {
                    SaleDateTime = item.SaleDateTime,
                    ProductSellingPrice = item.ProductSellingPrice,
                    SaleId = item.SaleId,
                    GivenAmount = item.GivenAmount,
                    PaymentType = item.PaymentType,
                    Quantity = item.Quantity,
                    ReceivedAmount = item.ReceivedAmount,
                    ProductId = item.ProductId

                });

            }


            return;
        }
    }
}
