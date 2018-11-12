using Prism.Commands;
using System.Windows.Input;
using TaxOfficeApplication.Events;

namespace TaxOfficeApplication.ViewModels
{
    public sealed partial class ShellViewModel
    {
        public ICommand ShowContractorCommand
        {
            get => new DelegateCommand(() =>
            {
                this.eventAggregator.GetEvent<NavigateToEvent>().Publish("ContractorView");
                this.eventAggregator.GetEvent<GetContractorsEvent>().Publish();
            });
        }

        public ICommand ExitCommand
        {
            get => new DelegateCommand(() => { this.IsClose = true; }, () => true);
        }
    }
}
