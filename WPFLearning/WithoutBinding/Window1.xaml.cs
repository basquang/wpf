﻿using System;
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

namespace WithoutBinding
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Person person = new Person {Name="Nguyen Ba Quang", Age = 28 };
        public Window1()
        {
            InitializeComponent();
            txtName.Text = person.Name;
            txtAge.Text = person.Age.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ///person.Age = person.Age + 1;
            MessageBox.Show("Your name is: " + txtName.Text);
        }
    }
}
