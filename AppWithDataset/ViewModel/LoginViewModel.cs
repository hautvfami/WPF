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
    class LoginViewModel : PropertyChangedBase
    {
        // End storage UserList


        public USER UserInfo{get;set;}
        public LoginViewModel()
        {
            registerCommand();
        }


        public void processLogin(USER u){
            USER user = Model.Users.handleLogin(u.USERNAME, u.PASSWORD);
            AppWithDataset.App.UserName = user.USERNAME;
            AppWithDataset.App.CodeUser = Convert.ToInt32(user.CODE);
            AppWithDataset.App.isLogin = true;
        }
        // Begin action commands
        private void registerCommand()
        {
            LoginCommand = new RelayCommand<USER>(null, u => { this.processLogin(u);});
        }

        public ObservableCollection<USER> Users { get; set; }
        public ICommand LoginCommand { get; set; }
        // End action commands
    }
}
