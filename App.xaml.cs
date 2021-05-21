using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Views;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        [STAThread()]
        static void Main()
        {
            //UserMainWindow us = new UserMainWindow();
            //AdminMainWindow uss = new AdminMainWindow();
            //AdminProductsWindow uss1 = new AdminProductsWindow();
            //RegWindow us = new RegWindow();
            AuthWindow auth = new AuthWindow();
            //AdminPurchaseHistory auth = new AdminPurchaseHistory();
            App app = new App();
            app.InitializeComponent();
            app.Run(auth);
        }
    }
    
}
