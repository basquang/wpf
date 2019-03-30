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

namespace WpfCommandApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static RoutedCommand InsertCustomer = new RoutedCommand();
        People people;
        public MainWindow()
        {
            InitializeComponent();
            people = this.FindResource("vietISpeople") as People;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Person person = new Person();
            person.Name = txtName.Text;
            person.Age = txtAge.Text;
            people.Add(person);

            txtName.Text = txtAge.Text = string.Empty;
        }

        private void InsertCustomer_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void InsertCustomer_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Executed!");
        }
    }
}
