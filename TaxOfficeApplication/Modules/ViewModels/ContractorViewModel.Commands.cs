using Prism.Commands;
using System.Windows.Input;
using TaxOfficeApplication.Events;
using TaxOfficeApplication.Models;
using TaxOfficeApplication.Modules.Views;

namespace TaxOfficeApplication.Modules.ViewModels
{
    public sealed partial class ContractorViewModel
    {
        public DelegateCommand<Contractor> ContractorsSelectedCommand { get; private set; }

        private void ContractorsSelected(Contractor contractor)
        {
            if (contractor != null)
            {

            }
        }



        public ICommand AddContractorCommand
        {
            get => new DelegateCommand(() =>
            {
                var vm = new EditContractorsViewModel(new Contractor());
                bool? success = this.dialogService.ShowDialog<EditContractors>(this, vm);
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
                var vm = new EditContractorsViewModel(c.Clone() as Contractor);

                bool? success = this.dialogService.ShowDialog<EditContractors>(this, vm);
                if (success == true)
                {
                    //wysłanie komunikatu o edycji nowego KH.
                    this.eventAggregator.GetEvent<EditContractorEvent>().Publish(vm.Contractor);
                }

            }, c => c != null);
        }

    }
}
