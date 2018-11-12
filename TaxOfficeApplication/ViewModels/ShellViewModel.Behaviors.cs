namespace TaxOfficeApplication.ViewModels
{
    public sealed partial class ShellViewModel
    {
        private bool isClosing = false;

        public bool IsClosing
        {
            get => this.isClosing;
            set => this.SetProperty(ref this.isClosing, value);
        }
    }
}
