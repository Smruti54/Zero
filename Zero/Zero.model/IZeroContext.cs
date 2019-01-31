using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zero.model
{
    /// <summary>
    /// this interface contains all models of type IDbset
    /// IDbSet<TEntity> was originally intended to allow creation of test doubles (mocks or fakes) for DbSet<TEntity>
    /// </summary>
    public interface IZeroContext:IDisposable
    {
        IDbSet<Product> Products { get; set; }


    }
}
