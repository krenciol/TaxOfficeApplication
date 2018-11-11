using System;
using MvvmDialogs;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using TaxOfficeApplication.Events;
using TaxOfficeApplication.Interfaces;

namespace TaxOfficeApplication.ViewModels
{
    public sealed partial class ShellViewModel : BindableBase
    {
        private readonly IBackgroundService backgroundService;
        private readonly IDialogService _dialogService;
        private readonly IEventAggregator eventAggregator;
        private readonly IRegionManager regionManager;

        public ShellViewModel(IBackgroundService backgroundService, IDialogService dialogService, IEventAggregator eventAggregator, IRegionManager regionManager)
        {
            this.backgroundService = backgroundService;
            this._dialogService = dialogService;
            this.eventAggregator = eventAggregator;
            this.regionManager = regionManager;

           // this.eventAggregator.GetEvent<TaskItemInsertEvent>().Subscribe(e => { this.Message = e.Description; }, ThreadOption.UIThread);
           // this.eventAggregator.GetEvent<MemoryStatusEvent>().Subscribe(e => { this.MemoryStatus = e; }, ThreadOption.UIThread);
           // this.eventAggregator.GetEvent<MemoryStatusEvent>().Publish(1);







            //użycie menu - wołanie okna po wybraniu przycisku
            this.eventAggregator.GetEvent<NavigateToEvent>().Subscribe(n =>
            {
                this.regionManager.RequestNavigate("ContentRegion", new Uri(n, UriKind.Relative));
            }, ThreadOption.UIThread);
        }
    }
}