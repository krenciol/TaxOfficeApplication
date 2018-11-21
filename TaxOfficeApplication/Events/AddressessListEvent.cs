using Prism.Events;
using System.Collections.Generic;
using TaxOfficeApplication.Models;

namespace TaxOfficeApplication.Events
{
    public sealed class AddressessListEvent : PubSubEvent<List<Addresses>>
    {

    }
}