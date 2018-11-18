using System;

namespace TaxOfficeApplication.ViewModels
{
    public sealed partial class ShellViewModel
    {
        private string message = string.Empty;

        private DateTime currentDate;

        private string title = Properties.Settings.Default.AppTitle;

        private long memoryStatus = -1;

        private decimal width = 800;
        private decimal height = 450;

        public string Message
        {
            get { return this.message; }
            set { this.SetProperty(ref this.message, value); }
        }

        public DateTime CurrentDate
        {
            get { return this.currentDate; }
            set { this.SetProperty(ref this.currentDate, value); }
        }

        public string Title
        {
            get { return this.title; }
            set { this.SetProperty(ref this.title, value); }
        }

        public long MemoryStatus
        {
            get { return this.memoryStatus; }
            set { this.SetProperty(ref this.memoryStatus, value); }
        }

        public decimal Width
        {
            get => this.width;
            set => SetProperty(ref this.width, value);
        }

        public decimal Height
        {
            get => this.height;
            set => SetProperty(ref this.height, value);
        }
    }
}
