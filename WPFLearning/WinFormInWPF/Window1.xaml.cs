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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;

namespace WinFormInWPF
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            DataGridView gridView = new DataGridView();
            gridView.DataSource = new People { 
            new Person{Name = "Nguyen Ba Quang",Age=28},
            new Person{Name = "Trinh Minh Cuong",Age=35},
            };
            windowsFormsHost1.Child = gridView;
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class People : List<Person>
    { }
}
