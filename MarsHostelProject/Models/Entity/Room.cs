using MarsHostelProject.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarsHostelProject.Models.Entity
{
    public class Room
    {
        public Room()
        {
            Status = Status.Active;
        }
        public int ID { get; set; }
        public decimal Price { get; set; }
        public int NumberOfPeople { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public Status Status { get; set; }

        //Mapping
        public List<Rezervation> Rezervations { get; set; }

    }
}