using MvvmDialogs;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using TaxOfficeApplication.Events;

namespace TaxOfficeApplication.Modules.ViewModels
{
    public sealed partial class ContractorViewModel : BindableBase
    {

        public IDialogService dialogService { get; }
        public IRegionManager regionManager { get; }
        public IEventAggregator eventAggregator;

        public ContractorViewModel(IEventAggregator eventAggregator, IDialogService dialogService,
            IRegionManager regionManager)
        {
            this.dialogService = dialogService;
            this.regionManager = regionManager;
            this.eventAggregator = eventAggregator;


            // wysłanie event do bacgraoudservice o zwrócenie listy KH.
            // po naciśnięciu przycisku kontrahenci.

            this.eventAggregator.GetEvent<ContractorsListEvent>().Subscribe(items =>
            {
                foreach (var item in items)
                {
                    if (!this.Items.Contains(item))
                    {
                        this.Items.Add(item);
                    }
                }
            }, ThreadOption.UIThread, true);
        }
    }
}