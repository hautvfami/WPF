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
using System.IO;

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
            get { return _selectedUser; }
            set
            {
                if (_selectedUser != null)
                {
                    _selectedUser = value;
                }
                else
                {
                    _selectedUser = new USER();
                } OnPropertyChanged("SelectedUser");
            }
        }
        public UserViewModel()
        {
            UserList = new ObservableCollection<USER>(Model.Users.getAllUsers() as List<USER>);
            registerCommand();
            SelectedUser = UserList.First();
        }

        private void Refresh()
        {
            if (UserList != null)
            {
                UserList = null;
            }
            UserList = new ObservableCollection<USER>(Model.Users.getAllUsers() as List<USER>);
        }


        public void _setPic()
        {
            Console.WriteLine("=======debug _setPic ============");
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.ShowDialog();
            if (dlg.FileName != null)
            {
                FileStream fs = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read);
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, System.Convert.ToInt32(fs.Length));
                SelectedUser.AVATAR = data;
                fs.Close();
                OnPropertyChanged("SelectedUser");
            }
        }

        // Begin action commands
        private void registerCommand()
        {
            DeleteCommand = new RelayCommand<USER>(u => u != null, u => { Model.Users.handleDelete(u.ID); Refresh(); });
            AddCommand = new RelayCommand<USER>(null, u => { Model.Users.handleInsert(u); Refresh(); });
            UpdateCommand = new RelayCommand<USER>(u => u != null, u => { Model.Users.handleUpdate(u); Refresh(); });
            EmptyCommand = new RelayCommand<USER>(u => u != null, u => { SelectedUser = new USER(); });
            SetPicCommand = new RelayCommand<USER>(null, u => { this._setPic(); });
        }

        public ObservableCollection<USER> Users { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand EmptyCommand { get; set; }
        public ICommand SetPicCommand { get; set; }
        // End action commands
    }
}
