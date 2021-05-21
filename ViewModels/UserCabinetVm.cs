using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp1.LoginNamespace;
using WpfApp1.Models;
using WpfApp1.Views;
using WpfApp1.Repository;

namespace WpfApp1.ViewModels
{
    public class UserCabinetVm:OnPropertyChangedClass
    {
        readonly UnitOfWork unitOfWork;
        public User InfoOfUsers;

        public string Name
        {
            get
            {
                return InfoOfUsers.Name;
            }
            set
            {
                InfoOfUsers.Name = value;
                OnPropertyChanged("Name");
            }
        }
        public string LName
        {
            get
            {
                return InfoOfUsers.LName;
            }
            set
            {
                InfoOfUsers.LName = value;
                OnPropertyChanged("LName");

            }
        }
        public string Discription
        {
            get
            {
                return InfoOfUsers.Discription;
            }
            set
            {
                InfoOfUsers.Discription = value;
                OnPropertyChanged("Discription");

            }
        }
        public string Login
        {
            get
            {
                return InfoOfUsers.login;
            }
            set
            {
                InfoOfUsers.login = value;
                OnPropertyChanged("Login");

            }
        }
        

        public ObservableCollection<User> CollectionExtensions { get; set; }

        string  thisLogin = Logins.login;
       

        public UserCabinetVm()
        {
            unitOfWork = new UnitOfWork();

            CollectionExtensions = new ObservableCollection<User>(unitOfWork.UsersRepository.GetAllObjectInList());

            using (UserContext context = new UserContext())
            {

                InfoOfUsers = unitOfWork.UsersRepository.GetAllObjectInList().Where(p => p.login == thisLogin).FirstOrDefault();

                if (InfoOfUsers != null)
                {
                    CollectionExtensions.Add(InfoOfUsers);
                    OnPropertyChanged("CollectionExtensions");
                }
            }
        }
        public ICommand MoveToUserMainWindow
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    ViewController view = ViewController.GetInstance();
                    UserMainWindow uc = new UserMainWindow();
                    view.CloseAndShow(uc);
                });
            }
        }
        public ICommand Exit
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


        public ICommand PurchaseHistory
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    ViewController view = ViewController.GetInstance();
                    UserPurchasesHistoryWindow uc = new UserPurchasesHistoryWindow();
                    view.CloseAndShow(uc);
                });
            }
        }

        public ICommand Update
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    if (string.IsNullOrEmpty(Name))
                    {
                        MessageBox.Show("Проверьте правильность ввода имени");
                    }
                    else
                    {
                        if (Name.Length >= 10)
                        {
                            MessageBox.Show("Имя не может быть длиннее 10 символов");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(LName))
                            {
                                MessageBox.Show("Проверьте правильность ввода фамилии");

                            }
                            else
                            {
                                if (LName.Length >= 10)
                                {
                                    MessageBox.Show("Фамилия не может быть длиннее 10 символов");

                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(Discription))
                                    {
                                        MessageBox.Show("Описание не может быть пустым ");
                                    }
                                    else
                                    {
                                        if (Discription.Length >= 50)
                                        {
                                            MessageBox.Show("Описание не может привышать 50 символов");

                                        }
                                        else { unitOfWork.Save(); MessageBox.Show("Изменения успешно зафиксированы");}
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
