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

namespace WpfListBindingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        People people;
        public MainWindow()
        {
            InitializeComponent();
            people = (People)this.FindResource("VietISPeople");
        }

        ICollectionView GetMicrosoftView()
        {            
            return CollectionViewSource.GetDefaultView(people);
        }

        private void Current_Click(object sender, RoutedEventArgs e)
        {
            var view = GetMicrosoftView();
            Person person = view.CurrentItem as Person;
            MessageBox.Show(person.Name);
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            var view = GetMicrosoftView();
            view.MoveCurrentToNext();
            if(view.IsCurrentAfterLast)
            {
                view.MoveCurrentToFirst();
            }
        }

        private void Previous_Click(object sender, RoutedEventArgs e)
        {
            var view = GetMicrosoftView();
            view.MoveCurrentToPrevious();
            if(view.IsCurrentBeforeFirst)
            {
                view.MoveCurrentToLast();
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Person person = new Person();
            person.Name = txtName.Text;
            person.Age = Int32.Parse(txtAge.Text);

            people.Add(person);
            txtName.Text = txtAge.Text = string.Empty;
        }
    }
}
