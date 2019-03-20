using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace WPFConsole
{
    class HelloWPF: Application
    {
        [STAThread]
        static void Main(string[] args)
        {
            HelloWPF app = new HelloWPF();
            app.Startup += new StartupEventHandler(app_Startup);
            app.Run();
        }

        static void app_Startup(object sender, StartupEventArgs e)
        {
            Window window = new Window1();
            window.Show();
        }
    }
}
