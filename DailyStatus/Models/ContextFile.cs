using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DailyStatus.Models
{
    public class ContextFile: DbContext
    {
        public ContextFile() : base("name=DbConnectionString") { }
        public DbSet<Intern> intern { get; set; }

        public DbSet<Login> login { get; set; }

        public DbSet<Status> status { get; set; }
    }
}