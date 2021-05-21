using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1.Else
{
    /// <summary>
    /// Логика взаимодействия для BindablePasswordBox1.xaml
    /// </summary>
    public partial class BindablePasswordBox1 : UserControl
    {
        public string Password1
        {
            get { return (string)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PasswordProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password1", typeof(string), typeof(BindablePasswordBox1),
                new PropertyMetadata(string.Empty));

        public BindablePasswordBox1()
        {
            InitializeComponent();
        }
        private void PassBoxName_PasswordChanged1(object sender, RoutedEventArgs e)
        {
            Password1 = textBoxPasswordRepeat.Password;
        }
    }
}
