using System;

namespace TaxOfficeApplication.Models
{
    public sealed class Address
    {
        public int id { get; set; }
        public int super { get; set; }
        public int typ { get; set; }
        public int flag { get; set; }
        public bool aktywny { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string street { get; set; }
        public string apartament { get; set; }
        public string office { get; set; }
        public string postalCode { get; set; }
        public string place { get; set; }
        public string community { get; set; }
        public string country { get; set; }
        public string voivodeship { get; set; }
        public int createdBy { get; set; }
        public DateTime createdDate { get; set; }
        public int modifiedBy { get; set; }
        public DateTime modifiedDate { get; set; }

        public Notes Notes = new Notes();

    }
}