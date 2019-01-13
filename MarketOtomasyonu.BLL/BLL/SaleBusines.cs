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

        public int MakeOrder(CartViewModel cart)
        {
            var satislar = new SaleRepo().GetAll();
            var detaylar = new SaleDetailRepo().GetAll();



            var sale = new Sale()
            {

            };
            new SaleRepo().Insert(sale);
            foreach (var item in cart.CartModel)
            {
                new SaleDetailRepo().Insert(new SaleDetail()
                {
                    SaleDateTime = item.SaleDateTime,
                    ProductSellingPrice = item.ProductSellingPrice,
                    SaleId = sale.SaleId,
                    GivenAmount = item.GivenAmount,
                    PaymentType = item.PaymentType,
                    Quantity = item.Quantity,
                    ReceivedAmount = item.ReceivedAmount,
                    ProductId = item.ProductId

                });
            }

            return sale.SaleId;
        }
    }
}
