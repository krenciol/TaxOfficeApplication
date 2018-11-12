using System;
using System.ComponentModel;
using System.Windows;

namespace TaxOfficeApplication.Views
{
    /// <summary>
    /// Interaction logic for ShellView.xaml
    /// </summary>
    public partial class ShellView : Window
    {
        public ShellView()
        {
            InitializeComponent();
        }

        private void ShellView_OnClosing(object sender, CancelEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
