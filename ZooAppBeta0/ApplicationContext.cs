using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ZooAppBeta0
{
    class ApplicationContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }

        public ApplicationContext() : base("Data Source=./ZooDatabase.db") { }




    }
}
