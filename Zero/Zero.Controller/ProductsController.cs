using System;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNet.OData;
using Zero.model;
using Zero.Manager.EntityManager;

using Zero.Manager.IManager;
namespace Zero.Controller
{

   public class ProductsController:ZeroServiceBaseController<Product>
    {
        IProductManager _productManager;
        public ProductsController(IZeroContextFactory zeroContextFactory,IProductManager Prodcuctmanager):base(zeroContextFactory) {
            _productManager = Prodcuctmanager;
        }

        [EnableQuery]
        public IQueryable<Product> GetProducts()
        {
            return _productManager.GetProducts();
        }

       
    }
}
