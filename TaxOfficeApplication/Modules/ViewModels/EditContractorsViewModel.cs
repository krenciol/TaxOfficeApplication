using MvvmDialogs;
using Prism.Events;
using Prism.Mvvm;
using TaxOfficeApplication.Events;
using TaxOfficeApplication.Models;

namespace TaxOfficeApplication.Modules.ViewModels
{
    public sealed partial class EditContractorsViewModel : BindableBase, IModalDialogViewModel
    {

        public IEventAggregator eventAggregator;

        public EditContractorsViewModel(Contractor contractor, IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
            this._contractor = contractor;



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

        public bool? DialogResult { get; private set; } = false;
    }
}