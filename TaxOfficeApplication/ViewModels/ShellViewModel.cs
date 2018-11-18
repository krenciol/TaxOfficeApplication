using MvvmDialogs;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using TaxOfficeApplication.Events;
using TaxOfficeApplication.Interfaces;

namespace TaxOfficeApplication.ViewModels
{
    public sealed partial class ShellViewModel : BindableBase, IDisposable
    {
        private volatile bool disposed;


        private readonly IBackgroundService backgroundService;
        private readonly IDialogService dialogService;
        private readonly IEventAggregator eventAggregator;
        private readonly IRegionManager regionManager;

        public ShellViewModel(IBackgroundService backgroundService, IDialogService dialogService, IEventAggregator eventAggregator, IRegionManager regionManager)
        {
            this.backgroundService = backgroundService;
            this.dialogService = dialogService;
            this.eventAggregator = eventAggregator;
            this.regionManager = regionManager;

            // this.eventAggregator.GetEvent<TaskItemInsertEvent>().Subscribe(e => { this.Message = e.Description; }, ThreadOption.UIThread);
            this.eventAggregator.GetEvent<MemoryStatusEvent>().Subscribe(e => { this.MemoryStatus = e; }, ThreadOption.UIThread);
            this.eventAggregator.GetEvent<MemoryStatusEvent>().Publish(1);


            this.eventAggregator.GetEvent<CurrentDateEvent>().Subscribe(e => { this.CurrentDate = e; }, ThreadOption.UIThread);
            this.eventAggregator.GetEvent<CurrentDateEvent>().Publish(DateTime.Now);







            //użycie menu - wołanie okna po wybraniu przycisku
            this.eventAggregator.GetEvent<NavigateToEvent>().Subscribe(n =>
            {
                this.regionManager.RequestNavigate("ContentRegion", new Uri(n, UriKind.Relative));
            }, ThreadOption.UIThread);
        }

        ~ShellViewModel()
        {
            this.Dispose(false);
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (this.disposed)
            {
                return;
            }

            if (disposing)
            {
            }

            this.disposed = true;
        }
    }
}