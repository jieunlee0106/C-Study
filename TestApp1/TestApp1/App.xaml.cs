using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TestApp1.Models;

namespace TestApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        
        protected override void OnStartup(StartupEventArgs e)
        {

            base.OnStartup(e);
            MainWindow window = new MainWindow();
            UserViewModel VM = new UserViewModel();
            window.DataContext = VM;
            window.Show();
        }
    }
}
