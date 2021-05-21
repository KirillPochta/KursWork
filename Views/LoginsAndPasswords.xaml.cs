using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.ViewModels;

namespace WpfApp1.Views
{
    /// <summary>
    /// Логика взаимодействия для LoginsAndPasswrods.xaml
    /// </summary>
    public partial class LoginsAndPasswrods : Window
    {
    
        public LoginsAndPasswrods()
        {
            ViewController view = ViewController.IntitializeComponent(this);

            InitializeComponent();
            
         

        }
      
    }
 
}
