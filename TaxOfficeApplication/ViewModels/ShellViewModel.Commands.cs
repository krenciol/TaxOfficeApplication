using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using TaxOfficeApplication.Events;

namespace TaxOfficeApplication.ViewModels
{
    public sealed partial class ShellViewModel
    {
        public ICommand ShowContractorCommand
        {
            get => new DelegateCommand(() =>
            {
                this.eventAggregator.GetEvent<NavigateToEvent>().Publish("SampleView");
          //      this.eventAggregator.GetEvent<GetContractorsEvent>().Publish();
            });
        }
    }
}
