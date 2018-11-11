using System.Windows;
using MvvmDialogs;
using Prism.Events;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using TaxOfficeApplication.Interfaces;
using TaxOfficeApplication.Services;
using TaxOfficeApplication.Views;

namespace TaxOfficeApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            var eventAggregator = this.Container.Resolve<IEventAggregator>();
            containerRegistry.RegisterInstance<IBackgroundService>(new ShellBackgroundService(eventAggregator));



            containerRegistry.RegisterInstance<IDialogService>(new DialogService());
        }

        protected override Window CreateShell()
        {
            return this.Container.Resolve<ShellView>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);

          //  moduleCatalog.AddModule(typeof(SampleModule));
          //  moduleCatalog.AddModule(typeof(Sample2Module));
        }
    }
}
