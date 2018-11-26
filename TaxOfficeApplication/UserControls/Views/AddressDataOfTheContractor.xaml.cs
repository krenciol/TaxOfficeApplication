using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using TaxOfficeApplication.Models;

namespace TaxOfficeApplication.UserControls.Views
{
    /// <summary>
    /// Interaction logic for Address_Data_Of_The_Contractor.xaml
    /// </summary>
    public partial class AddressDataOfTheContractor : UserControl
    {
        public AddressDataOfTheContractor()
        {
            this.InitializeComponent();
            ((FrameworkElement) this.Content).DataContext = this;
        }
        public static readonly DependencyProperty AddressProperty = DependencyProperty.Register("Address", typeof(ObservableCollection<Address>), typeof(AddressDataOfTheContractor), new FrameworkPropertyMetadata(null));

        public Address Address
        {
            get
            {
                return (Address)this.GetValue(AddressProperty);
            }
            set
            {
                this.SetValue(AddressProperty, value);
            }
        }
    }
}
