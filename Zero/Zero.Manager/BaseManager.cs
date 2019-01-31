using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zero.model;
namespace Zero.Manager
{
   public class BaseManager
    {
        private bool disposed;

        public IZeroContext ZeroDataContext { get; set; }

        /// <summary>
        /// common base manager for initialize  Database for corresponding context
        /// </summary>
        /// <param name="zeroContextFactory"></param>
        public BaseManager(IZeroContextFactory zeroContextFactory)
        {
            ZeroDataContext = zeroContextFactory.GetZeroContext();
        }


        public BaseManager(IZeroContext _zeroDataContext)
        {
            ZeroDataContext = _zeroDataContext;
        }
        ~BaseManager()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!disposed)
            {
                DoDispose();
                disposed = true;
            }
        }

        protected virtual void DoDispose()
        {


        }

    }
}
