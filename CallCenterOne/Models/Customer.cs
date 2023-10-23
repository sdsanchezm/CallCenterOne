using System.ComponentModel.DataAnnotations;

namespace CallCenterOne.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public Store Store { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }
        public Priority Priority1 { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
