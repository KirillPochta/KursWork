using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1.ViewModels
{
    class ViewController
    {
        Window window { get; set; }

        private static ViewController instance;
        public static ViewController GetInstance() => instance;

        protected ViewController(Window window)
        {
            this.window = window;
        }
        public static ViewController IntitializeComponent(Window window)
        {
            if (instance == null)
            {
                instance = new ViewController(window);
            }
            return instance;
        }
        public void CloseAndShow(Window window)
        {
            this.window.Close();
            this.window = window;
            this.window.Show();
        }
    }
}
