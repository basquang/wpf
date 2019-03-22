using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfMvvmApp.Model;

namespace WpfMvvmApp.ViewModel
{
    public class UpdaterCommand : ICommand
    {
        #region ICommand Members 
        public bool CanExecute(object parameter)
        {
            if (parameter != null && parameter is User)
            {
                User user = parameter as User;
                return user.UserId % 2 == 0? true : false;
            }
            return false;
        }
        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }
        public void Execute(object parameter)
        {
            if (parameter != null && parameter is User)
            {
                User user = parameter as User;
                MessageBox.Show(string.Format("{0} {1} updated!", user.FirstName, user.LastName));
            }            
        }
        #endregion
    }
}
