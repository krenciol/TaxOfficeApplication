namespace TaxOfficeApplication.UserControls.ViewModels
{
    public sealed partial class ContractorViewModel
    {

        private TaxOfficeApplication.Models.Contractor contractor;


        public TaxOfficeApplication.Models.Contractor Contractor
        {
            get => this.contractor;
            set => SetProperty(ref this.contractor, value);
        }

    }
}
