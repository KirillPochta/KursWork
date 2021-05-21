using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp1.Repository;

namespace WpfApp1.ViewModels
{
    public class RegWindowVm:OnPropertyChangedClass
    {
        readonly UnitOfWork unitOfWork;

        public RegWindowVm()
        {
            unitOfWork = new UnitOfWork();
        }

        public string TextBoxLogin { get; set; }
        public string _pass;
        public string Pass {
            get
            {
                return _pass;
            }
            set
            {
                _pass = value;
                OnPropertyChanged("Pass");
            } 
        }
        public string _pass1;
        public string Pass1 
        {
            get
            {
                return _pass1;
            }
            set 
            {
                _pass1 = value;
                OnPropertyChanged("Pass1");
            }
        }

        public string LoginToolTip { get; set; }
        public string PasswordToolTip { get; set; }
        public string PasswordToolTipRepeat { get; set; }

        public Brush BackgroundLoginBox { get; set; }
        public Brush BackgroundPasswordBox { get; set; }
        public Brush BackgroundPasswordBoxRepeat { get; set; }

        public ICommand Button_Auth_Click
        {
            get
            {
                return new DelegateCommand((obj) =>
                {

                    ViewController view = ViewController.GetInstance();
                    AuthWindow uc = new AuthWindow();
                    view.CloseAndShow(uc);

                });
            }
        }
        public ICommand Registration_Button
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    bool role = false;
         
                    if (string.IsNullOrEmpty(TextBoxLogin))
                    {
                        MessageBox.Show("Проверьте ввод логина");
                    }
                    else
                    {
                        if (TextBoxLogin.Contains(" "))
                        {
                            MessageBox.Show("В логине не может быть пробелов");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(Pass))
                            {
                                MessageBox.Show("Проверьте ввод пароля");
                            }
                            else
                            {
                                if (Pass != Pass1)
                                {
                                    MessageBox.Show("Пароли не совпадают");
                                }
                                else
                                {
                                    User user1 = unitOfWork.UsersRepository.GetAllObjectInList().Where
                                    (us => us.login == TextBoxLogin).FirstOrDefault();
                                    if (user1 != null)
                                    {
                                        MessageBox.Show("Такой логин уже зарегестрирован\n" +
                                                "придумайте другой");
                                    }
                                    else
                                    {
                                        unitOfWork.UsersRepository.Create(new User(TextBoxLogin, Pass, role));
                                        unitOfWork.Save();

                                        ViewController view = ViewController.GetInstance();
                                        AuthWindow uc = new AuthWindow();
                                        view.CloseAndShow(uc);
                                    }

                                }
                            }
                        }
                    }
                });
            }
        }
    }
}
