using MarsHostelProject.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MarsHostelProject.Models.Context
{
    public class MarsHostelContext : DbContext
    {
        public MarsHostelContext()
        {
            Database.Connection.ConnectionString = "server=GROOVYPRIMAT\\SQLEXPRESS;database=MarsHostelDB;Trusted_Connection=True;";
        }

        public DbSet<Rezervation> Rezervations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}