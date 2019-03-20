using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace WithBinding
{
    public class Person: INotifyPropertyChanged
    {
        string name;
        public string Name
        {
            get { return name; }
            set {
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
        public Person() { }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;
        protected void Notify(string propName)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        #endregion
    }
}
