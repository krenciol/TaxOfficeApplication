using System.Collections.ObjectModel;
using TaxOfficeApplication.Models;

namespace TaxOfficeApplication.Modules.ViewModels
{
    public sealed partial class EditContractorsViewModel
    {
        private Contractor _contractor;
        private ObservableCollection<Address> addresses = new ObservableCollection<Address>();

        public Contractor Contractor
        {
            get => this._contractor;
            set => this.SetProperty(ref this._contractor, value);
        }

        public ObservableCollection<Address> Addresses
        {
            get => this.addresses;
            set => this.SetProperty(ref this.addresses, value);
        }
    }
}
