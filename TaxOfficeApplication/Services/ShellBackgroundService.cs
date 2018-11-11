using Prism.Events;
using TaxOfficeApplication.Interfaces;

namespace TaxOfficeApplication.Services
{
    public class ShellBackgroundService: IBackgroundService
    {
        private readonly IEventAggregator eventAggregator;

        public ShellBackgroundService(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
        }
        
    }
}