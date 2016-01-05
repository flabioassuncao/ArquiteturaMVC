using Ninject;

namespace FA.ArquiteturaMVC.CrossCuting.IoC
{
    public class Container
    {
        public StandardKernel GetModule()
        {
            return new StandardKernel(new ArquiteturaMvcModulo());
        }
    }
}
