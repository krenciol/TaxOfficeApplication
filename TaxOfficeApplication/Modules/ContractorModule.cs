using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using TaxOfficeApplication.Modules.Views;

namespace TaxOfficeApplication.Modules
{
    public sealed class ContractorModule: IModule
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(ContractorView));
        }
    }
}