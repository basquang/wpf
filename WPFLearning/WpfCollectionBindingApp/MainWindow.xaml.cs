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

namespace WpfCollectionBindingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Person> list = new List<Person>
        {
            new Person{ Name = "Quang", Age = 35, LikeColor = FavouriteColors.Green},
            new Person{Name = "Duc", Age = 24, LikeColor = FavouriteColors.Red}
        };
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = list;         
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public FavouriteColors LikeColor { get; set; }
    }

    public enum FavouriteColors
    {
        Red, Green, Blue
    }
}
