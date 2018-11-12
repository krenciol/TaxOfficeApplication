using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace TaxOfficeApplication.Models
{
    public sealed class Contractor : System.IEquatable<Contractor>, System.ICloneable
    {
        public int id { get; }
        public int super { get; set; }
        public int typ { get; set; }
        public int flag { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public int marker { get; set; }
        public int catalog { get; set; }
        public string nip { get; set; }
        public string regon { get; set; }
        public string pesel { get; set; }
        public bool statusUe{ get; set; }
        public int countryId { get; set; }
        public string bankName { get; set; }
        public string bankAccount { get; set; }
        public bool naturalPerson_LegalPerson { get; set; }
        public int createdBy { get; set; }
        public DateTime createdDate { get; set; }
        public int modifiedBy { get; set; }
        public DateTime modifiedDate { get; set; }


//        public List<Addresses> AddrsList = new List<Addresses>();
//        public Notes Notes = new Notes();

        public object Clone()
        {
            var item = (Contractor)this.MemberwiseClone();
            return item;
        }



        public bool Equals(Contractor other)
        {
            return other != null && this.id.Equals(other.id);
        }
    }
}