using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp1.ViewModels;
using WpfApp1.Views;
using System.Runtime.CompilerServices;
using System.Windows;
using WpfApp1.Repository;
using System.Windows.Data;
using WpfApp1;

namespace WpfApp1
{
   

    class LoginsAndPasswordsVm:OnPropertyChangedClass
    {
       
        public ObservableCollection<User> AllUsersInListBox { get; set; }

        public bool RadioButtonIsSelected { get; set; }

        readonly UnitOfWork unitOfWork = new UnitOfWork();
        private RelayCommand _switchTOAdmim;
        public RelayCommand SwitchToAdminCommand => _switchTOAdmim ?? (_switchTOAdmim = new RelayCommand(SwitchToAdminMethod));
        public LoginsAndPasswordsVm()
        {
            AllUsersInListBox = new ObservableCollection<User>(unitOfWork.UsersRepository.GetAllObjectInList());

        }
        private void SwitchToAdminMethod(object parameter)
        {
            if (parameter is User user)
            {
                if (user.role == true)
                {
                    MessageBox.Show($"{user.login} - Уже явялется даминстратором");
                }
                else
                {
                    if (user.role == false)
                    {
                        user.role = true;
                        unitOfWork.Save();
                        MessageBox.Show("Роль успешна изменена");
                        AllUsersInListBox.Clear();
                        AllUsersInListBox = new ObservableCollection<User>(unitOfWork.UsersRepository.GetAllObjectInList());
                        OnPropertyChanged("AllUsersInListBox");
                    }
                }
            }
        }
        public ICommand ReturnToTheAdminCabinet
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    ViewController view = ViewController.GetInstance();
                    AdminCabinet admCab = new AdminCabinet();
                    view.CloseAndShow(admCab);
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
                    AuthWindow authWindow = new AuthWindow();
                    view.CloseAndShow(authWindow);
                });
            }
        }
    } 
}
