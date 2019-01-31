using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zero.model
{
    /// <summary>
    /// this model helps you create object for your database connection
    /// </summary>
    public class ZeroContextFactroy : IZeroContextFactory
    {
        private Lazy<IZeroContext> _zeroContex;
        public ZeroContextFactroy(ModelContext.Factory zeFactory)
        {
            _zeroContex=new Lazy<IZeroContext>(() => { return zeFactory(); });
        }
        ~ZeroContextFactroy()
        {
            Dispose();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (_zeroContex.IsValueCreated) { _zeroContex.Value.Dispose(); }
        }
        public IZeroContext GetZeroContext()
        {
            return _zeroContex.Value;
        }
    }

    public interface IZeroContextFactory
    {
        IZeroContext GetZeroContext();
    }
}
