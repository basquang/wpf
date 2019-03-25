using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfEf6MvvmApp.Model;
using System.Data.Entity;
using System.Collections.ObjectModel;

namespace WpfEf6MvvmApp.ViewModel
{
    public class CustomerViewModel : INotifyPropertyChanged
    {
        NorthwindEntities northwindEntities = new NorthwindEntities();
        public CustomerViewModel()
        {
            LoadData();
        }

        void LoadData()
        {
            northwindEntities.Customers.Load();
            Customers = northwindEntities.Customers.Local;
        }

        public ObservableCollection<Customer> Customers;

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
