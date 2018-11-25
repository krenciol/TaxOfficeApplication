using System.Collections.ObjectModel;
using TaxOfficeApplication.Models;

namespace TaxOfficeApplication.UserControls.ViewModels
{
    public sealed partial class GeneralDataOfTheContractor
    {
        private Contractor contractor;
        private ObservableCollection<Address> addresses;

        public ObservableCollection<Address> Addresses
        {
            get => this.addresses;
            set => this.SetProperty(ref this.addresses, value);
        }

        public Contractor Contractor
        {
            get => this.contractor;
            set => this.SetProperty(ref this.contractor, value);
        }
    }
}
