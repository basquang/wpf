using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FixedDocuments
{
    /// <summary>
    /// Interaction logic for PrintSummary.xaml
    /// </summary>
    public partial class PrintSummary : Window
    {
        public PrintSummary()
        {
            InitializeComponent();
            PopulateGrid();  
        }
        void PopulateGrid()
        {
            List<Customer> customers = new List<Customer>();
            for (int i = 1; i <= 200; i++)
            {
                Customer customer = new Customer();
                customer.FirstName = "First Name " + i;
                customer.LastName = "Last Name " + i;
                customers.Add(customer);
            }
            this.DataContext = customers;
        }
    }
}
