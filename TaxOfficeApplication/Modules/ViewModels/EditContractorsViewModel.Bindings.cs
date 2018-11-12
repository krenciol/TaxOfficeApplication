using TaxOfficeApplication.Models;

namespace TaxOfficeApplication.Modules.ViewModels
{
    public sealed partial class EditContractorsViewModel
    {
        private Contractor _contractor;

        public Contractor Contractor
        {
            get => this._contractor;
            set => this.SetProperty(ref this._contractor, value);
        }

    }
}
