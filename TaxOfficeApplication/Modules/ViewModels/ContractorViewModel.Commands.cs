﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Regions;
using TaxOfficeApplication.Events;
using TaxOfficeApplication.Models;
using TaxOfficeApplication.Modules.Views;

namespace TaxOfficeApplication.Modules.ViewModels
{
    public sealed partial class ContractorViewModel
    {
        public DelegateCommand<Contractors> ContractorsSelectedCommand { get; private set; }

        private void ContractorsSelected(Contractors contractors)
        {
            if (contractors != null)
            {

            }
        }



        public ICommand AddContractorCommand
        {
            get => new DelegateCommand(() =>
            {
                var vm = new EditContractorsViewModel(new Contractors());
                bool? success = this.dialogService.ShowDialog<EditContractors>(this, vm);
                if (success == true)
                {
                    //wysłanie komunikatu o dodaniu nowego KH.
                    this.eventAggregator.GetEvent<AddContractorEvent>().Publish(vm.Contractor);
                }

            });
        }

        public ICommand EditContractorCommand
        {
            get => new DelegateCommand<Contractors>(c =>
            {
                var vm = new EditContractorsViewModel(c.Clone());

                bool? success = this.dialogService.ShowDialog<EditContractors>(this, vm);
                if (success == true)
                {
                    //wysłanie komunikatu o edycji nowego KH.
                    this.eventAggregator.GetEvent<EditContractorEvent>().Publish(vm.Contractor);
                }

            }, c => c != null);
        }

    }
}