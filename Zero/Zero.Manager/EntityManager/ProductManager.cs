using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zero.Manager.IManager;
using Zero.model;
namespace Zero.Manager.EntityManager
{
   public class ProductManager:BaseManager,IProductManager
    {
        public ProductManager(IZeroContextFactory zeroContextFactory):base(zeroContextFactory)
        {

        }

        public IQueryable<Product> GetProducts()
        {
            return ZeroDataContext.Products.AsQueryable();
        }
    }
}
