using Prism.Events;
using Prism.Mvvm;
using TaxOfficeApplication.Events;

namespace TaxOfficeApplication.UserControls.ViewModels
{
    public sealed partial class GeneralDataOfTheContractor : BindableBase
    {
        private readonly IEventAggregator eventAggregator;

        public GeneralDataOfTheContractor(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;

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