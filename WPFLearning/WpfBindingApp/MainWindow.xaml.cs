using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfBindingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person person = new Person
        {
            Name = "Nguyen Ba Quang",
            Age = 35
        };
        public MainWindow()
        {
            InitializeComponent();            
            layoutGrid.DataContext = person;
            btnSubmit.Click += BtnSubmit_Click;
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(person.Name);
            person.Name = "Le Tuan Anh";
            MessageBox.Show(person.Name);
        }
    }

    public class Person : INotifyPropertyChanged
    {
        string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (name == value) { return; }
                name = value;
                Notify("Name");
            }
        }
        int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (age == value) { return; }
                age = value;
                Notify("Age");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void Notify(string propName)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
