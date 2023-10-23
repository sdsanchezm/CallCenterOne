namespace CallCenterOne.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public Store StoreLocation { get; set; }
        public Country CountryClient { get; set; }
        public City City { get; set; }
        public Priority Priority1 { get; set; }
        public Priority Priority2 { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
