using System.Collections.ObjectModel;
using TaxOfficeApplication.Models;

namespace TaxOfficeApplication.UserControls.ViewModels
{
    public sealed partial class ContractorViewModel
    {
        private bool canAddAddress = false;

        private TaxOfficeApplication.Models.Contractor contractor;

        private ObservableCollection<Addresses> addresseses = new ObservableCollection<Addresses>();


        public TaxOfficeApplication.Models.Contractor Contractor
        {
            get => this.contractor;
            set => SetProperty(ref this.contractor, value);
        }

        public ObservableCollection<Addresses> Addresseses
        {
            get => this.addresseses;
            set => SetProperty(ref this.addresseses, value);
        }

        public bool CanAddAddress
        {
            get => this.canAddAddress;
            set { this.SetProperty(ref this.canAddAddress, value); }
        }
    }
}
