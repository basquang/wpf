using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDataValidationApp
{
    public class Person: INotifyPropertyChanged
    {
        string name;
        public string Name {
            get { return name; }
            set
            {
                if (name == value) { return; }
                name = value;
                if (string.IsNullOrEmpty(name))
                {
                    throw new ApplicationException("Name is mandatoty!");
                }
                Notify("Name");
            }
        }
        public int Age { get; set; }

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
