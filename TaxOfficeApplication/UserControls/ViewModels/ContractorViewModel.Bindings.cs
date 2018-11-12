using TaxOfficeApplication.Models;

namespace TaxOfficeApplication.UserControls.ViewModels
{
    public sealed partial class ContractorViewModel
    {

        private Contractor _newContractor;


        public Contractor NewContractor
        {
            get => this._newContractor;
            set => SetProperty(ref this._newContractor, value);
        }

    }
}
