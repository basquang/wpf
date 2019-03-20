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

namespace Commands
{
    /// <summary>
    /// Interaction logic for CustomRoutedUICommand.xaml
    /// </summary>
    public partial class CustomRoutedUICommand : Window
    {
        public CustomRoutedUICommand()
        {
            InitializeComponent();
        }

        private void InsertCustomer_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void InsertCustomer_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ListBoxItem item = new ListBoxItem();
            item.Content = "New Customer";
            lsbCustomers.Items.Add(item);
        }
    }
}
