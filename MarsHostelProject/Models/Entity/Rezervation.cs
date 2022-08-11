using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarsHostelProject.Models.Entity
{
    public class Rezervation
    {
        public int ID { get; set; }
        public DateTime FirstDate { get; set; }
        public DateTime LastDate { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal SubTotal { get; set; }
        //Mapping
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public List<Customer> Customers { get; set; }

    }
}