using System.Diagnostics;

namespace CallCenterOne.Models
{
    public class Priority
    {
        public int Id { get; set; }
        public string PriorityName { get; set; }
        public int PriorityNumber { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}