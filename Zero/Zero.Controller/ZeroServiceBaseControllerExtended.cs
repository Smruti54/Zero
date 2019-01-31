using Microsoft.AspNet.OData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zero.model;
namespace Zero.Controller
{
  public abstract partial  class ZeroServiceBaseController<TEntity> : ODataController where TEntity : class
    {
        private IZeroContext _ZeroDataContext;

        protected bool isDispose = true;

        public IZeroContext ZeroDataContext
        {
            get
            {
                return _ZeroDataContext;
            }
        }
    }
}
