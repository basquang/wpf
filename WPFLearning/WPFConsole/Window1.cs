using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace WPFConsole
{
    public class Window1: Window
    {
        public Window1()
        {
            this.Title = "Hello WPF!";
            Button button = new Button();
            button.Content = "Click me!";
            button.Width = 200;
            button.Height = 25;
            button.Click += new RoutedEventHandler(button_Click);
            this.AddChild(button);
        }

        void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World WPF");
        }
    }
}
