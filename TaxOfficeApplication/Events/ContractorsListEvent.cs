using System.Collections.Generic;
using Prism.Events;
using TaxOfficeApplication.Models;

namespace TaxOfficeApplication.Events
{
    public sealed class ContractorsListEvent : PubSubEvent<List<Contractors>>
    {
        
    }
}