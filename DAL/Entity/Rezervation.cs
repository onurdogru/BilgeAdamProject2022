using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Rezervation
    {
        public int ID { get; set; }
        public DateTime FirstDate { get; set; }
        public DateTime LastDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
