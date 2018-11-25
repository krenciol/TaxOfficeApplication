using Prism.Events;
using Prism.Mvvm;
using TaxOfficeApplication.Events;

namespace TaxOfficeApplication.UserControls.ViewModels
{
    public sealed partial class ContractorViewModel : BindableBase
    {
        private readonly IEventAggregator eventAggregator;

        public ContractorViewModel(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;


            //GetAdressessEvent

            //
            //            this.eventAggregator.GetEvent<EditContractorEvent>()
            //                .Subscribe(c => this.Contractor = c, ThreadOption.UIThread);

            this.eventAggregator.GetEvent<AddressesListEvent>().Subscribe(items =>
            {
                foreach (var item in items)
                {
                    if (!this.Addresses.Contains(item))
                    {
                        this.Addresses.Add(item);
                    }
                }
            }, ThreadOption.UIThread, true);



        }

    }
}