using MarketOtomasyonu.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.BLL.Repository
{
   public class SaleRepo : RepositoryBase<Sale>
    {

        public override List<Sale> GetAll()
        {
            return base.GetAll().OrderBy(x => x.SaleId).ToList();
        }

        public override int Insert(Sale entity)
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
