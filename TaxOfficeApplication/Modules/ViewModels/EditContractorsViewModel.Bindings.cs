using TaxOfficeApplication.Models;

namespace TaxOfficeApplication.Modules.ViewModels
{
    public sealed partial class EditContractorsViewModel
    {
        private Contractors contractor;

        public Contractors Contractor
        {
            get => this.contractor;
            set => this.SetProperty(ref this.contractor, value);
        }

    }
}
