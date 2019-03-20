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

namespace UsingSettings
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        string[] mySettings = { 
                            "Settings 1",
                            "Setting 2",
                            "Setting 3",
                            "Setting 4",
                            "Setting 5"
                            };
        Random rnd = new Random();
        public Window1()
        {
            InitializeComponent();
            myUserSetting.Text = Properties.Settings.Default.MyUserSetting;
            //Save new User setting
            Properties.Settings.Default.MyUserSetting = mySettings[rnd.Next(mySettings.Length - 1)];
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            //Save user settings between sesssions
            Properties.Settings.Default.Save();
        }
    }
}
