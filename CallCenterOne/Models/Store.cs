using System.ComponentModel.DataAnnotations;

namespace CallCenterOne.Models
{
    public class Store
    {
        [Key]
        public int Id { get; set; }
        public string StoreName { get; set; }
        public string StoreNumber { get; set; }
        public DateTime CreationDate { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}