using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCommandApp
{
    public class Person
    {
        public string Name { get; set; }
        public string Age { get; set; }
    }
    public class People : ObservableCollection<Person>
    { }
}
