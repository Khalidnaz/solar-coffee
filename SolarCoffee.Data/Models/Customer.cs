using System;
using System.Collections.Generic;
using System.Text;

namespace SolarCoffee.Data.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public DateTime CreateOn { get; set; }
        public DateTime UpdateOn { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public CustomerAddress PrimaryAddress { get; set; }
    }
}
