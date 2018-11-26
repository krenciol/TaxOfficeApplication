using Prism.Commands;
using System.Windows.Input;
using TaxOfficeApplication.Events;

namespace TaxOfficeApplication.ViewModels
{
    public sealed partial class ShellViewModel
    {

        private ICommand fileExitCommand;

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

        public ICommand FileExitCommand
        {
            get
            {
                if (this.fileExitCommand == null)
                {
                    this.fileExitCommand = new DelegateCommand(() => { this.IsClose = true; });
                }

                return this.fileExitCommand;
            }
        }

    }
}
