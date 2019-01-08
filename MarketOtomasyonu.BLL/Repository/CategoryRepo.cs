using MarketOtomasyonu.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.BLL.Repository
{
   public class CategoryRepo:RepositoryBase<Category>
    {
        public override List<Category> GetAll()
        {
            return base.GetAll().OrderBy(x => x.CategoryName).ToList();
        }
        public override int Insert(Category entity)
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
