using System;

namespace TaxOfficeApplication.Models
{
    public sealed class Notes
    {
        public int id { get; set; }
        public int super { get; set; }
        public int typ { get; set; }
        public int flag { get; set; }
        public bool active { get; set; }
        public string notes { get; set; }
        public int createdBy { get; set; }
        public DateTime createdDate { get; set; }
        public int modifiedBy { get; set; }
        public DateTime modifiedDate { get; set; }
    }
}