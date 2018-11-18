using Prism.Events;
using System;

namespace TaxOfficeApplication.Events
{
    public sealed class CurrentDateEvent : PubSubEvent<DateTime>
    {

    }
}