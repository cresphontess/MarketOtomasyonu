using MarketOtomasyonu.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.BLL.Repository
{
    public class ProductRepo : RepositoryBase<Product>
    {
        public override List<Product> GetAll()
        {
            return base.GetAll().OrderBy(x => x.ProductName).ToList();
        }

        public override int Insert(Product entity)
        {
            try
            {

                return base.Insert(entity);
            }
            catch
            {
                throw;
            }
        }
    }
}
