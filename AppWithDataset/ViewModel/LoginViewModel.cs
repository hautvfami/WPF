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


//namespace WPF.ViewModels
//{
//    public class LoginViewModel : BaseViewModel
//    {

//         public event EventHandler LoginCompleted;

//         public void RaiseLoginCompleted()
//        {
//            if (LoginCompleted != null)
//            {
//                LoginCompleted(this, EventArgs.Empty);
//            }
//        }

//        private string login;
//        private string password;

//        public string Login
//        {
//            get { return login; }
//            set { login = value; OnPropertyChanged("Login"); }
//        }

//        private void OnPropertyChanged(string p)
//        {
//            throw new NotImplementedException();
//        }

//        public string Password {
//            private get { return password; }
//            set { password = value; OnPropertyChanged("Password"); }
//        }

//        public void LoginOp(object o)
//        {
//            #Validation logic
//            RaiseLoginCompleted();
//        }

//        public ICommand LoginCommand { get; set; }

//        public LoginViewModel() {    
//            LoginCommand = new DelegateCommand(LoginOp);
//            OnPropertyChanged("LoginOp");
//        }   
//    }
//}
namespace AppWithDataset.ViewModel
{
    class LoginViewModel : PropertyChangedBase
    {
        public event EventHandler LoginCompleted;

        private USER userInfo = new USER();
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
                RaiseLoginCompleted();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
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
