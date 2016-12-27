using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MySql_SqLite_Synchronization.Models;
using System.Data.SQLite;
using MySql_SqLite_Synchronization;

namespace MySql_SqLite_Synchronization.DbContext
{
    public class AppContext : System.Data.Entity.DbContext
    {

        public AppContext() : base(AppConstants.MYSQL_CONNECTION_STRING)
        {

        }

        public AppContext(string connectionString) : base(connectionString)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Contract> Contracts { get; set; }
    }
}
