using MySql_SqLite_Synchronization;
using MySql_SqLite_Synchronization.DataRetrieval;
using MySql_SqLite_Synchronization.DbContext;
using MySql_SqLite_Synchronization.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql_SqLite_Synchronization.ViewModels
{
    public class MainControlViewModel
    {
        UsersDataRetrieval _usersDataRetrieval;

        IList<User> _usersSqLite;
        IList<User> _usersMySql;

        internal IList<User> GetAllUsers_MYSQL()
        {
            _usersDataRetrieval = new UsersDataRetrieval(() => new AppContext(AppConstants.MYSQL_CONNECTION_STRING));
            _usersMySql = new List<User>(_usersDataRetrieval.GetAllUsers());

            return _usersMySql;
        }

        internal IList<User> GetAllUsers_SQLITE()
        {
            _usersDataRetrieval = new UsersDataRetrieval(() => new AppContext(AppConstants.SQLITE_CONNECTION_STRING));
            _usersSqLite = new List<User>(_usersDataRetrieval.GetAllUsers());

            return _usersSqLite;
        }

        internal void InsertItem_SQLITE(User user)
        {
            _usersDataRetrieval = new UsersDataRetrieval(() => new AppContext(AppConstants.SQLITE_CONNECTION_STRING));
            _usersDataRetrieval.InsertItem(user);
        }

        internal void InsertItem_MYSQL(User user)
        {
            _usersDataRetrieval = new UsersDataRetrieval(() => new AppContext(AppConstants.MYSQL_CONNECTION_STRING));
            _usersDataRetrieval.InsertItem(user);
        }
    }
}
