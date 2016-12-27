using MySql_SqLite_Synchronization.DbContext;
using MySql_SqLite_Synchronization.Models;
using MySql_SqLite_Synchronization.Views;
using System;
using System.Collections.Generic;
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

namespace MySql_SqLite_Synchronization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            grdContentHolder.Children.Add(new MainControlView(this));
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            ResetContent();
        }

        internal void ResetContent()
        {
            grdContentHolder.Children.Clear();
            grdContentHolder.Children.Add(new MainControlView(this));
        }
    }
}
