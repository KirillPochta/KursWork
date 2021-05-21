using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp1.Models;
using WpfApp1.Views;
using WpfApp1.Repository;

namespace WpfApp1.ViewModels
{
    public class AdminMainWindowVM:OnPropertyChangedClass
    {
  
        public ObservableCollection<Advert> ItemForListBox  { get; set;}

        readonly UnitOfWork unitOfWork;

        public string NameOfadvertFromAddWindow { get; set; }
        public string ContentOfadvertFromAddWindow { get; set; }
        public string AuthorOfadvertFromAddWindow { get; set; }

        public string ChangeNameOfadvertFromAddWindow { get; set; }
        public string ChangeContentOfadvertFromAddWindow { get; set; }
        public string ChangeAuthorOfadvertFromAddWindow { get; set; }

        private RelayCommand _removeCommand;
        private RelayCommand _showContent;
        private RelayCommand _changeAdvertCommand;


        public AdminMainWindowVM()
        {
            unitOfWork = new UnitOfWork();
            ItemForListBox = new ObservableCollection<Advert>(unitOfWork.AdvertsRepository.GetAllObjectInList());
        }

        public RelayCommand RemoveCommand => _removeCommand ?? (_removeCommand = new RelayCommand(RemoveMetod));
        public RelayCommand ShowContentCommand => _showContent ?? (_showContent = new RelayCommand(ShowContentMetod));
        public RelayCommand ChangeAdvertCommand => _changeAdvertCommand ?? (_changeAdvertCommand = new RelayCommand(ChangeAdvertMethod));
        
        public ICommand BackFromAddWindow
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                        ViewController view = ViewController.GetInstance();
                        AdminMainWindow admWindow = new AdminMainWindow();
                        view.CloseAndShow(admWindow);  
                });
            }
        }
        public ICommand BackCmd
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    DateTime dt = DateTime.Now;
                    if (string.IsNullOrEmpty(ChangeAuthorOfadvertFromAddWindow) || string.IsNullOrEmpty(ChangeContentOfadvertFromAddWindow)
                    || string.IsNullOrEmpty(ChangeNameOfadvertFromAddWindow) || string.IsNullOrEmpty(dt.ToString()))
                    {
                        MessageBox.Show("Внесите изменения прежде чем выйти");
                    }
                    else
                    {
                        ViewController view = ViewController.GetInstance();
                        AdminMainWindow admWindow = new AdminMainWindow();
                        view.CloseAndShow(admWindow);
                    }

                });
            }
        }
        public ICommand MoveToTheAdminsProductWindow
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    ViewController view = ViewController.GetInstance();
                    AdminProductsWindow adminProductsWindow = new AdminProductsWindow();
                    view.CloseAndShow(adminProductsWindow);

                });
            }
        }
        public ICommand AddNewAdvert
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    ViewController view = ViewController.GetInstance();
                    AddNewAdvertWindow addWindow = new AddNewAdvertWindow();
                    view.CloseAndShow(addWindow);

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
        public ICommand ReturnToTheAdminCabinet
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    ViewController view = ViewController.GetInstance();
                    AdminCabinet adminCabWindow = new AdminCabinet();
                    view.CloseAndShow(adminCabWindow);

                });
            }
        }
        public ICommand ChangeAdvertCommand1
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    DateTime dt = DateTime.Now;
                    if (string.IsNullOrEmpty(ChangeNameOfadvertFromAddWindow))
                    {
                        MessageBox.Show("Праверьте правильность изменения названия новости");

                    }
                    else
                    {
                        if (ChangeNameOfadvertFromAddWindow.Length >=15 )
                        {
                            MessageBox.Show("Навзание новости не должно превышать 15 символов");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(dt.ToString()))
                            {
                                MessageBox.Show("Праверьте правильность изменения даты публикации");

                            }
                            else
                            {
                                if (string.IsNullOrEmpty(ChangeAuthorOfadvertFromAddWindow))
                                {
                                    MessageBox.Show("Праверьте правильность изменения имени автора");

                                }
                                else
                                {
                                    if (ChangeAuthorOfadvertFromAddWindow.Length >= 25)
                                    {
                                        MessageBox.Show("Имя  автора не должно превышать 25 символов");
                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(ChangeContentOfadvertFromAddWindow))
                                        {
                                            MessageBox.Show("Проверьте правильность изменения содержимого новости");
                                        }
                                        else
                                        {
                                            if (ChangeContentOfadvertFromAddWindow.Length>=400)
                                            {
                                                MessageBox.Show("Описание новости не должно превышать 400 символов");
                                            }
                                            else
                                            {
                                                if (true)
                                                {
                                                    Advert user1 = unitOfWork.AdvertsRepository.GetAllObjectInList().Where
                                                    (us => us.NameOfAdvert == ChangeNameOfadvertFromAddWindow).FirstOrDefault();
                                                    if (user1 != null)
                                                    {
                                                        MessageBox.Show("Такая новость уже существует,придумайте другео название");

                                                    }
                                                    else
                                                    {
                                                        unitOfWork.AdvertsRepository.Create(new Advert(dt, ChangeAuthorOfadvertFromAddWindow,
                                                        ChangeContentOfadvertFromAddWindow, ChangeNameOfadvertFromAddWindow, LoginNamespace.Logins.login));
                                                        unitOfWork.Save();
                                                        MessageBox.Show("Новость успешна изменена");
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                });
            }
        }

        private void ChangeAdvertMethod(object parameter)
        {
            if (parameter is Advert advert)
            {
                ItemForListBox.Remove(advert);
                unitOfWork.AdvertsRepository.Delete(advert);
                unitOfWork.Save();
                ViewController view = ViewController.GetInstance();
                ChangeAdvertWindow editWindow = new ChangeAdvertWindow();
                view.CloseAndShow(editWindow);
            }
        }
        public ICommand AddNewAdvertFromWindow
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    DateTime dt = DateTime.Now;
                    try
                    {
                        if (string.IsNullOrEmpty(NameOfadvertFromAddWindow))
                        {
                            MessageBox.Show("Праверьте правильность ввода названия новости");
                        }
                        else
                        {
                            if (NameOfadvertFromAddWindow.Length >= 20)
                            {
                                MessageBox.Show("Длинна названия не доджна привышать 20 символов");
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(AuthorOfadvertFromAddWindow))
                                {
                                    MessageBox.Show("Праверьте правильность ввода имени автора");
                                }
                                else
                                { 
                                    if (AuthorOfadvertFromAddWindow.Length >= 25 )
                                    {
                                        MessageBox.Show("Имя автора не должно превышать 25 символов");
                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(ContentOfadvertFromAddWindow))
                                        {
                                            MessageBox.Show("Проверьте правильность ввода содержимого новости");
                                        }
                                        else
                                        {
                                            if (ContentOfadvertFromAddWindow.Length >= 400)
                                            {
                                                MessageBox.Show("Информация о новости не должна привышать 400 символов");
                                            }
                                            else
                                            {
                                                if (true)
                                                {
                                                    Advert user1 = unitOfWork.AdvertsRepository.GetAllObjectInList().Where
                                                    (us => us.NameOfAdvert == NameOfadvertFromAddWindow).FirstOrDefault();

                                                    if (user1 != null)
                                                    {
                                                        MessageBox.Show("Такая новость уже существует,придумайте другео название");

                                                    }
                                                    else
                                                    {
                                                        unitOfWork.AdvertsRepository.Create(new Advert(dt, AuthorOfadvertFromAddWindow,
                                                            ContentOfadvertFromAddWindow, NameOfadvertFromAddWindow, LoginNamespace.Logins.login));
                                                        unitOfWork.Save();
                                                        MessageBox.Show("Новость успешна добавлена");
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Проверьте правильность ввода данных");
                    }
                });
            }
        }
        private void RemoveMetod(object parameter)
        {
            if (parameter is Advert item)
            {
                ItemForListBox.Remove(item);
                unitOfWork.AdvertsRepository.Delete(item);
                unitOfWork.Save();
                OnPropertyChanged("ItemForListBox");
                MessageBox.Show("Объект успешно удален");
            }
        }

        private void ShowContentMetod(object parameter)
        {
            if (parameter is Advert advert)
                MessageBox.Show(advert.Content.ToString() + "\n" + "Автор - " + advert.Author +"\nДоавил - " + advert.whoAddAdvert);
        }
    }
} 

