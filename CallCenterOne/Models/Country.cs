﻿namespace CallCenterOne.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public DateTime CountryCreationDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}