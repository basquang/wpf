using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            foreach(var f in Fonts.SystemFontFamilies)
            {
                ListBoxItem lb = new ListBoxItem();
                lb.Content = f;
                lb.FontFamily = f;
                listbox1.Items.Add(lb);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //textBlock.Text = "Hello Viet IS";
        }

        private void Listbox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var fontSelected =  listbox1.SelectedItem as ListBoxItem;
            richtextbox1.Selection.ApplyPropertyValue(FontFamilyProperty, fontSelected.Content);
        }
    }
}
