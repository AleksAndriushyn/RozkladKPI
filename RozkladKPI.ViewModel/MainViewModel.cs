using RozkladKPI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RozkladKPI.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        private ObservableCollection<Schedule> _schedules;
        public ObservableCollection<Schedule> Schedules
        {
            get
            {
                return _schedules;
            }
            set
            {
                _schedules = value;
                OnPropertyChanged("Schedules");
            }
        }
        private ObservableCollection<Class> _classes;
        public ObservableCollection<Class> Classes
        {
            get
            {
                return _classes;
            }
            set
            {
                _classes = value;
                OnPropertyChanged("Classes");
            }
        }
        private ObservableCollection<User> _users;
        public ObservableCollection<User> Users
        {
            get
            {
                return _users;
            }
            set
            {
                _users = value;
                OnPropertyChanged("Users");
            }
        }

        public MainViewModel()
        {
            Schedules = new ObservableCollection<Schedule>();
            Classes = new ObservableCollection<Class>();
            Users = new ObservableCollection<User>();
        }
    }
}
