using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.ViewModels;
using WpfApp1.Views;
using WpfApp1.LoginNamespace;
using System.Windows.Input;
using System.Data.Entity;
using System.Windows;
using System.Collections.ObjectModel;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using WpfApp1.Repository;
namespace WpfApp1
{
    public class AdminCabinetVm:OnPropertyChangedClass
    {

        readonly UnitOfWork unitOfWork;
        public User InfoOfUsers;
        
        public string Name {
            get
            {
                return InfoOfUsers.Name;
            }
            set
            {
                InfoOfUsers.Name = value;
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
            }
        }

        public ObservableCollection<User> collectionExtensions { get; set; }

        string thisLogin = Logins.login;

        public AdminCabinetVm()
        {
            unitOfWork = new UnitOfWork();
            collectionExtensions = new ObservableCollection<User>();
            using (UserContext context = new UserContext())
            {

                InfoOfUsers = unitOfWork.UsersRepository.GetAllObjectInList().Where
                    (p => p.login == thisLogin).FirstOrDefault();

                if (InfoOfUsers != null)
                {
                    collectionExtensions.Add(InfoOfUsers);
                }
            }
        }

        public ICommand MoveToAdminMainWindow
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    ViewController view = ViewController.GetInstance();
                    AdminMainWindow uc = new AdminMainWindow();
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
        public ICommand LoginsAndPasswordsOfUsers
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    ViewController view = ViewController.GetInstance();
                    LoginsAndPasswrods uc = new LoginsAndPasswrods();
                    view.CloseAndShow(uc);
                });
            }
        }
        public ICommand PurchaseOfAllUsers
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    ViewController view = ViewController.GetInstance();
                    AdminPurchaseHistory uc = new AdminPurchaseHistory();
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
                    if (string.IsNullOrEmpty(Name) )
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
                                        if(Discription.Length >= 50)
                                        {
                                            MessageBox.Show("Описание не может привышать 50 символов");

                                        }
                                        else { unitOfWork.Save(); MessageBox.Show("Изменения успешно зафиксированы"); }
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
