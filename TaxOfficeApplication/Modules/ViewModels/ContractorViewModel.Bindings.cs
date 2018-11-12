using System.Collections.ObjectModel;
using TaxOfficeApplication.Models;

namespace TaxOfficeApplication.Modules.ViewModels
{
    public sealed partial class ContractorViewModel
    {
        private ObservableCollection<Contractor> items = new ObservableCollection<Contractor>();
        private Contractor selectedItem = null;

        public ObservableCollection<Contractor> Items
        {
            get => this.items;
            set => this.SetProperty(ref this.items, value);
        }

        public Contractor SelectedItem
        {
            get => this.selectedItem;
            set => this.SetProperty(ref this.selectedItem, value);
        }
    }
}
