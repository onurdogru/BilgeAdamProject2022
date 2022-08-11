using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarsHostelProject.Models.Entity
{
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        //MApping
        public int RezervationId { get; set; }
        public Rezervation Rezervation { get; set; }
    }
}