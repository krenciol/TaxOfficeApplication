using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using Prism.Commands;

namespace TaxOfficeApplication.ViewModels
{
    public sealed partial class ShellViewModel
    {
        private bool isClose = false;

        public bool IsClose
        {
            get => this.isClose;
            set => this.SetProperty(ref this.isClose, value);
        }

        public ICommand WindowClosedCommand
        {
            get
            {
                return new DelegateCommand(this.Dispose);
            }
        }

        public ICommand WindowClosingCommand
        {
            get
            {
                return new DelegateCommand<CancelEventArgs>(
                    e =>
                    {
                        var result = this.dialogService.ShowMessageBox(
                            this,
                            "Do you want to close this window",
                            "Question...",
                            MessageBoxButton.YesNo);
                        e.Cancel = result != MessageBoxResult.Yes;
                    });
            }
        }
    }
}
