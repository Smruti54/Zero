using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Zero.model
{
    public class ModelContext : DbContext, IZeroContext
    {
        /// <summary>
        /// Connection bridge for your application
        /// </summary>
        /// <returns></returns>

        public delegate ModelContext Factory();
        public ModelContext():base("name = ZeroContext")
        {

            Database.SetInitializer<ModelContext>(null);
        }
     
        public virtual IDbSet<Product> Products { get; set; }

        public  void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
