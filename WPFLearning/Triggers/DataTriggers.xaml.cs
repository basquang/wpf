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
using System.Collections.ObjectModel;

namespace Triggers
{
    /// <summary>
    /// Interaction logic for DataTriggers.xaml
    /// </summary>
    public partial class DataTriggers : Window
    {
        public DataTriggers()
        {
            InitializeComponent();
        }
    }
    public class User
    {
        public string Name { get; set; }
        public string Role { get; set; }
    }
    public class Users : ObservableCollection<User>
    {
        public Users()
        {
            this.Add(new User { Name = "Nguyen Ba Quang", Role = "Admin" });
            this.Add(new User { Name = "Trinh Minh Cuong", Role = "Contributor" });
            this.Add(new User { Name = "Bill Gates", Role = "User" });
        }
    }
}
