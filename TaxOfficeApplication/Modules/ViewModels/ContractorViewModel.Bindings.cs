using System.Collections.ObjectModel;
using TaxOfficeApplication.Models;

namespace TaxOfficeApplication.Modules.ViewModels
{
    public sealed partial class ContractorViewModel
    {
        private ObservableCollection<Contractors> items = new ObservableCollection<Contractors>();
        private Contractors selectedItem = null;

        public ObservableCollection<Contractors> Items
        {
            get => this.items;
            set => this.SetProperty(ref this.items, value);
        }

        public Contractors SelectedItem
        {
            get => this.selectedItem;
            set => this.SetProperty(ref this.selectedItem, value);
        }
    }
}
