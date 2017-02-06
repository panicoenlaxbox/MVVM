using Microsoft.Practices.Unity;

namespace BlankXamlApp1.ViewModels.Base
{
    public class ViewModelLocator
    {
        private readonly IUnityContainer _container = new UnityContainer();

        public ViewModelLocator()
        {
            _container.RegisterInstance(new MainViewModel());
        }

        public MainViewModel MainViewModel => _container.Resolve<MainViewModel>();
    }
}