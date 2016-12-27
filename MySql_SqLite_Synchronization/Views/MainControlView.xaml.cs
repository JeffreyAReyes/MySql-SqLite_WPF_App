using MySql_SqLite_Synchronization.Models;
using MySql_SqLite_Synchronization.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace MySql_SqLite_Synchronization.Views
{
    /// <summary>
    /// Interaction logic for MainControl.xaml
    /// </summary>
    public partial class MainControlView : UserControl
    {
        MainControlViewModel _viewModel;
        MainWindow _mainWindow;

        User user = new User()
        {
            Name = "Dummy"
        };

        public MainControlView(MainWindow mainWindow)
        {
            InitializeComponent();
            _viewModel = new MainControlViewModel();
            _mainWindow = mainWindow;
            
            dgMySQL.ItemsSource = Populate_dgMySQL();
            dgSqLite.ItemsSource = Populate_dgSqLite();
        }



        private List<User> Populate_dgMySQL()
        {
            dgMySQL.ItemsSource = null;
            return new List<User>(_viewModel.GetAllUsers_MYSQL());
        }

        private List<User> Populate_dgSqLite()
        {   
            return new List<User>(_viewModel.GetAllUsers_SQLITE());
        }

        private void btnOverwriteMySQL_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnOverwriteSqLite_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnUpdateMySQL_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnUpdateSqLite_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAddItemMySql_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.InsertItem_MYSQL(user);
            _mainWindow.ResetContent();
        }

        private void btnAddItemSqLite_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.InsertItem_SQLITE(user);
            _mainWindow.ResetContent();
        }

        private void btnCopyMySqlToSqLite_Click(object sender, RoutedEventArgs e)
        {
            List<User> _allMySqlUsers = new List<User>(_viewModel.GetAllUsers_MYSQL());
            foreach (User _user in _allMySqlUsers)
            {
                _viewModel.InsertItem_SQLITE(_user);
            }
            _mainWindow.ResetContent();
        }
    }
}
