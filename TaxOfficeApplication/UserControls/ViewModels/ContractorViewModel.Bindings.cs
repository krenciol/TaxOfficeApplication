using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxOfficeApplication.Models;

namespace TaxOfficeApplication.UserControls.ViewModels
{
   public sealed  partial class ContractorViewModel
   {

       private Contractor _newContractor;


       public Contractor NewContractor
       {
           get => this._newContractor;
           set => SetProperty(ref this._newContractor, value);
       }

   }
}
