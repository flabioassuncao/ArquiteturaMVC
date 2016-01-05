using FA.ArquiteturaMVC.Infra.Data.Context;

namespace FA.ArquiteturaMVC.Infra.Data.Interfaces
{
    public interface IContextManager
    {
        ArquiteturaMVCContext GetContext();
    }
}
