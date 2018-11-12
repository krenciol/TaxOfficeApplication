namespace TaxOfficeApplication.UserControls.ViewModels
{
    public sealed partial class ContractorViewModel
    {
        private bool canAddAddress = false;

        private TaxOfficeApplication.Models.Contractor contractor;


        public TaxOfficeApplication.Models.Contractor Contractor
        {
            get => this.contractor;
            set => SetProperty(ref this.contractor, value);
        }

        public bool CanAddAddress
        {
            get => this.canAddAddress;
            set { this.SetProperty(ref this.canAddAddress, value); }
        }
    }
}
