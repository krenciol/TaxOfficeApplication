using System;

namespace TaxOfficeApplication.Models
{
    public sealed class Contractors : ICloneable
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

//        public Contractors Clone()
//        {
//            return new Contractors();
//        }

        object ICloneable.Clone()
        {
            return new Contractors();
        }
    }
}