namespace CallCenterOne.Models
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public DateTime CreationDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}