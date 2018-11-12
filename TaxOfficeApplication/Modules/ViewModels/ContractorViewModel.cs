using MvvmDialogs;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;

namespace TaxOfficeApplication.Modules.ViewModels
{
    public sealed partial class ContractorViewModel: BindableBase
    {
        public IDialogService dialogService { get; }
        public IRegionManager regionManager { get; }
        public IEventAggregator eventAggregator;

        public ContractorViewModel(IEventAggregator eventAggregator, IDialogService dialogService, IRegionManager regionManager)
        {
            this.dialogService = dialogService;
            this.regionManager = regionManager;
            this.eventAggregator = eventAggregator;
        }
    }
}