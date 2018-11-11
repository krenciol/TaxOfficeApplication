using System;
using System.Diagnostics;
using System.Windows.Threading;
using Prism.Events;
using TaxOfficeApplication.Events;
using TaxOfficeApplication.Interfaces;

namespace TaxOfficeApplication.Services
{
    public class ShellBackgroundService: IBackgroundService
    {
        private readonly IEventAggregator eventAggregator;
        private readonly DispatcherTimer dispatcherTimer = new DispatcherTimer(DispatcherPriority.Send);

        public ShellBackgroundService(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;

            this.eventAggregator = eventAggregator;

            this.dispatcherTimer.Interval = TimeSpan.FromMilliseconds(125);
            this.dispatcherTimer.Tick += (sender, e) =>
            {
                var currentProcess = Process.GetCurrentProcess();
                var memoryUsed = currentProcess.PrivateMemorySize64;
                this.eventAggregator.GetEvent<MemoryStatusEvent>().Publish(memoryUsed / 1024 / 1024);
            };
            this.dispatcherTimer.Start();
        }
        
    }
}