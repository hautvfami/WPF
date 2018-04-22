using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using AppWithDataset.ViewModel;

namespace AppWithDataset
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    ///
    public partial class App : Application
    {
        public static Int32 CodeUser;
        public static string UserName;
        public static bool isLogin = false;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            //View.MainWindow win = new View.MainWindow();
            View.LoginWindow LoginWindow = new View.LoginWindow();
            LoginWindow.Show();
            ((LoginViewModel)LoginWindow.DataContext).LoginCompleted += (s, ev) =>
            {
                View.MainWindow MainWindow = new View.MainWindow();
                LoginWindow.Hide();
                LoginWindow.Close();
                MainWindow.Show();
            };   
        }
    }
}
