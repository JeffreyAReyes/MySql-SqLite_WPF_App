using MySql_SqLite_Synchronization.DbContext;
using MySql_SqLite_Synchronization.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MySql_SqLite_Synchronization.DataRetrieval
{
    public class UsersDataRetrieval
    {
        private readonly Func<AppContext> _contextCreator;

        public UsersDataRetrieval(Func<AppContext> context)
        {
            _contextCreator = context;
        }

        public List<User> GetAllUsers()
        {   
            try
            {
                using (var context = _contextCreator())
                {
                    var results = from u in context.Users
                                  select u;

                    return new List<User>(results.ToList());
                }
            }
            catch(Exception ex)
            {
                string error = ex.ToString();
                return new List<User>();
            }
        }

        internal void InsertItem(User user)
        {
            try
            {
                using (var context = _contextCreator())
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
            }
        }
    }
}
