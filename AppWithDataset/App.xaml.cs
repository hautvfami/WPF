using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

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
            View.MainWindow win = new View.MainWindow();
            View.Login login = new View.Login();
            if (!isLogin)
            {
                login.Hide();
                win.Show();
            }
            else
            {
                win.Hide();
                login.Show();
            }
        }
    }
}
