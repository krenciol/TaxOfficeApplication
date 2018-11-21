using Prism.Events;
using Prism.Mvvm;

namespace TaxOfficeApplication.UserControls.ViewModels
{
    public sealed partial class ContractorViewModel : BindableBase
    {
        private readonly IEventAggregator eventAggregator;

        public ContractorViewModel(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;




            //
            //            this.eventAggregator.GetEvent<EditContractorEvent>()
            //                .Subscribe(c => this.Contractor = c, ThreadOption.UIThread);
        }

    }
}