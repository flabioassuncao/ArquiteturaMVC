using System;
using FA.ArquiteturaMVC.Infra.Data.Interfaces;
using System.Web;

namespace FA.ArquiteturaMVC.Infra.Data.Context
{
    public class ContextManager : IContextManager
    {
        private const string ContextKey = "ContextManager.Context";

        public ArquiteturaMVCContext GetContext()
        {
            if(HttpContext.Current.Items[ContextKey] == null)
            {
                HttpContext.Current.Items[ContextKey] = new ArquiteturaMVCContext();
            }

            return (ArquiteturaMVCContext) HttpContext.Current.Items[ContextKey];
        }
    }
}
