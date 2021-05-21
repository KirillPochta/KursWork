using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp1.ViewModels;
using WpfApp1.Views;
using WpfApp1.LoginNamespace;
using WpfApp1.Repository;

namespace WpfApp1
{
    
    public class AuthVM 
    {       
        public string Login { get; set; }
        public string Password { get; set; }
 

        readonly UnitOfWork unitOfWork;
        public AuthVM()
        {
            unitOfWork = new UnitOfWork();
        }

        public ICommand Button_Join_Click
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    ViewController view = ViewController.GetInstance();
                    RegWindow regWindow = new RegWindow();
                    view.CloseAndShow(regWindow);
              
                });
            }
        }
        public ICommand Button_Auth_Click
        {
            get
            {
                
                return new DelegateCommand((obj) =>
                {
                    try
                    {
                        string login = Login;


                        using (UserContext context = new UserContext())
                        {
                            User user = unitOfWork.UsersRepository.GetAllObjectInList()
                            .Where(us => us.login == Login && us.password == Password)
                            .FirstOrDefault();
                            

                            if (user == null)
                            {
                                MessageBox.Show("Проверьте правльность ввода логина");

                            }
                            else
                            {
                                
                                    ViewController view = null;
                                    Logins.login = null;
                                    Logins.login = Login ;
                                    switch (user.role)
                                    {
                                        case true:
                                            view = ViewController.GetInstance();
                                            AdminCabinet uc = new AdminCabinet();
                                            view.CloseAndShow(uc);
                                            break;
                                        case false:
                                            view = ViewController.GetInstance();
                                            UserCabinet usecab = new UserCabinet();
                                            view.CloseAndShow(usecab);
                                            break;
                                    }
                                
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("проверьте ввода данных");
                    }
                });
            }
        }
    }
}
