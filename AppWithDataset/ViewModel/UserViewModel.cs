using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using AppWithDataset.Model;

namespace AppWithDataset.ViewModel
{
    class UserViewModel : PropertyChangedBase
    {
        // Storage UserList
        private ObservableCollection<USER> _userList;
        public ObservableCollection<USER> UserList
        {
            get { return _userList; }
            set
            {
                if (_userList != value)
                {
                    _userList = value;
                    OnPropertyChanged("UserList");
                }
            }
        }
        // End storage UserList


        private USER _selectedUser;
        public USER SelectedUser
        {
            get
            {
                if (_selectedUser != null)
                {
                    Console.WriteLine("GetDebug===========" + _selectedUser.USERNAME);
                } return _selectedUser;
            }
            set { Console.WriteLine("SetDebug===========" + value.ADDRESS); _selectedUser = value; }
        }
        public UserViewModel()
        {
            UserList = new ObservableCollection<USER>(Model.Users.getAllUsers() as List<USER>);
            registerCommand();
        }

        private void Refresh()
        {
            if (UserList != null)
            {
                UserList = null;
            }
            UserList = new ObservableCollection<USER>(Model.Users.getAllUsers() as List<USER>);
        }


        // Begin action commands
        private void registerCommand()
        {
            DeleteCommand = new RelayCommand<USER>(u => u != null, u => { Model.Users.handleDelete(u.ID); Refresh(); });
            AddCommand = new RelayCommand<USER>(u => u != null, u => { Model.Users.handleInsert(u); Refresh(); });
            UpdateCommand = new RelayCommand<USER>(u => u != null, u => { Model.Users.handleUpdate(u); Refresh(); });
            //EmptyCommand = new RelayCommand<USER>(u => u != null, u => { SelectedUser = null; });
        }

        public ObservableCollection<USER> Users { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        //public ICommand EmptyCommand { get; set; }
        // End action commands
    }
}
