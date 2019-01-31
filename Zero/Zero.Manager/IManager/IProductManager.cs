using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zero.model;
namespace Zero.Manager.IManager
{
   public interface IProductManager: IDisposable
    {
        IQueryable<Product> GetProducts();
    }
}
