using Prism.Commands;
using System.Windows.Input;
using TaxOfficeApplication.Events;
using TaxOfficeApplication.Models;
using TaxOfficeApplication.Modules.Views;

namespace TaxOfficeApplication.Modules.ViewModels
{
    public sealed partial class ContractorViewModel
    {


        public ICommand AddContractorCommand
        {
            get => new DelegateCommand(() =>
            {
                var vm = new EditContractorsViewModel(new Contractor(), this.eventAggregator);
                bool? success = this.dialogService.ShowDialog<EditContractorsView>(this, vm);
                if (success == true)
                {
                    //wysłanie komunikatu o dodaniu nowego KH.
                    this.eventAggregator.GetEvent<AddContractorEvent>().Publish(vm.Contractor);
                }

            });
        }

        public ICommand EditContractorCommand
        {
            get => new DelegateCommand<Contractor>(c =>
            {
                this.eventAggregator.GetEvent<GetAddressesEvent>().Publish(c.id);


                var vm = new EditContractorsViewModel(c.Clone() as Contractor, this.eventAggregator);

                bool? success = this.dialogService.ShowDialog<EditContractorsView>(this, vm);
                if (success == true)
                {
                    //wysłanie komunikatu o edycji nowego KH.
                    this.eventAggregator.GetEvent<EditContractorEvent>().Publish(vm.Contractor);
                }

            }, c => c != null);
        }

    }
}
