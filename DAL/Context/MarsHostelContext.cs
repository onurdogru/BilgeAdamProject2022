using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class MarsHostelContext : DbContext
    {
        public MarsHostelContext()
        {
            Database.Connection.ConnectionString = "server=GROOVYPRIMAT\\SQLEXPRESS;database=MarsHostelDB;Trusted_Connection=True;";
        }

        public DbSet<Rezervation> Rezervations { get; set; }
    }
}
