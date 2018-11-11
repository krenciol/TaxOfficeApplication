using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxOfficeApplication.ViewModels
{
    public sealed partial class ShellViewModel
    {
        private string message = string.Empty;

        private string title =Properties.Settings.Default.AppTitle;

        private long memoryStatus = -1;

        public string Message
        {
            get { return this.message; }
            set { this.SetProperty(ref this.message, value); }
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
    }
}
