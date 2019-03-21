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
using WpfDataApp.Model;
using System.Data.Entity;

namespace WpfDataApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NorthwindEntities context = new NorthwindEntities();
        CollectionViewSource custViewSource;
        CollectionViewSource ordViewSource;

        public MainWindow()
        {
            InitializeComponent();
            custViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("customerViewSource")));            
            DataContext = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            context.Customers.Load();
            // Load data by setting the CollectionViewSource.Source property:         
            custViewSource.Source = context.Customers.Local;
        }
    }
}
