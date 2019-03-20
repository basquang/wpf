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
using System.ComponentModel;

namespace ListDataBinding
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        ICollectionView GetMicrosoftView()
        {
            People people = (People)this.FindResource("Microsoft");
            return CollectionViewSource.GetDefaultView(people);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ICollectionView view = GetMicrosoftView();
            Person person = (Person)view.CurrentItem;
            MessageBox.Show(person.Name + " is " + person.Age);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            ICollectionView view = GetMicrosoftView();
            view.MoveCurrentToPrevious();
            if (view.IsCurrentBeforeFirst)
            { 
                view.MoveCurrentToFirst();
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            ICollectionView view = GetMicrosoftView();
            view.MoveCurrentToNext();
            if (view.IsCurrentAfterLast)
            {
                view.MoveCurrentToLast();
            }
        }
    }
}
