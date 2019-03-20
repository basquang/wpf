using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Commands
{
    public static class MyCommands
    {
        public static RoutedUICommand InsertCustomer { get; private set; }

        static MyCommands()
        {
            InsertCustomer = new RoutedUICommand("Insert Customer", "Insert Customer",
                typeof(MyCommands));
        }
    }
}
