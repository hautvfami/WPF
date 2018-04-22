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
        public event EventHandler LoginCompleted;

        private USER userInfo = new USER();
        public String Message{get; set;}
        public USER UserInfo { get { return userInfo; } set { userInfo = value;} }
        public void passwordChanged()
        {
            MessageBox.Show("======");
        }
        public LoginViewModel()
        {
            registerCommand();
        }


        public void processLogin(USER u)
        {
            USER user = Model.Users.handleLogin(u.USERNAME, u.PASSWORD);
            if (user != null)
            {
                if (user.CODE <= 1)
                {
                    RaiseLoginCompleted();
                }
                else
                {
                    Message = "Bạn chưa được cấp quyền truy cập ứng dụng!";
                    OnPropertyChanged("Message");
                }
            }
            else
            {
                Message = "Sai tên đăng nhập hoặc mật khẩu!";
                OnPropertyChanged("Message");
            }
        }

        public void RaiseLoginCompleted()
        {
            if (LoginCompleted != null)
            {
                LoginCompleted(this, EventArgs.Empty);
            }
        }

        // Begin action commands
        private void registerCommand()
        {
            LoginCommand = new RelayCommand<USER>(null, o => { this.processLogin(UserInfo); });
        }

        public ObservableCollection<USER> Users { get; set; }
        public ICommand LoginCommand { get; set; }
        // End action commands

        public object LoginComplete { get; set; }
    }
}
