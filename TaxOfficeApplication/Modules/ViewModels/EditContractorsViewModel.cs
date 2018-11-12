using MvvmDialogs;
using Prism.Mvvm;
using TaxOfficeApplication.Models;

namespace TaxOfficeApplication.Modules.ViewModels
{
    public sealed partial class EditContractorsViewModel : BindableBase, IModalDialogViewModel
    {

        public EditContractorsViewModel(Contractors contractor)
        {
            this.contractor = contractor;
        }

        public bool? DialogResult { get; private set; } = false;
    }
}