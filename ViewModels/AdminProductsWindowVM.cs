using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp1.Models;
using WpfApp1.Views;
using System.Runtime.CompilerServices;
using WpfApp1.Repository;

namespace WpfApp1.ViewModels
{
    public class AdminProductsWindowVM:OnPropertyChangedClass
    {
        public ObservableCollection<Products> ItemsForProductsBox { get;  set; }
        readonly UnitOfWork unitOfWork;
        public Products SelectetListBoxItem { get; set; }
        public string ChangeNameOfProductFromWindow { get; set; }
        public string ChangeInfoOfProductFromWindow { get; set; }
        public int ChangeCostOfProductFromWindow { get; set; }
        public string NewNameOfProductFromAddWindow { get; set; }
        public string NewInfoOfProductFromAddWindow { get; set; }
        public int NewCostOfProductFromAddWindow { get; set; }

        private RelayCommand _removeCommand;
        private RelayCommand _showContent;
        private RelayCommand _changeAdvertCommand;

        public AdminProductsWindowVM()
        {
            unitOfWork = new UnitOfWork();
            ItemsForProductsBox = new ObservableCollection<Products>(unitOfWork.ProductsRepository.GetAllObjectInList());
        }

        public RelayCommand RemoveCommand => _removeCommand ?? (_removeCommand = new RelayCommand(RemoveMetod));
        public RelayCommand ShowInfoOfProductCommand => _showContent ?? (_showContent = new RelayCommand(ShowProductInfoMetod));
        public RelayCommand ChangeProductCommand => _changeAdvertCommand ?? (_changeAdvertCommand = new RelayCommand(ChangeProductMethod));
        
        public ICommand BackCmdFormAddWindow
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    ViewController view = ViewController.GetInstance();
                    AdminProductsWindow adminMainWindow = new AdminProductsWindow();
                    view.CloseAndShow(adminMainWindow);

                });
            }
        }

        public ICommand MoveToTheAdminAdvertWindow
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    ViewController view = ViewController.GetInstance();
                    AdminMainWindow adminMainWindow = new AdminMainWindow();
                    view.CloseAndShow(adminMainWindow);

                });
            }
        }
        
        public ICommand AddNewProduct
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    if (string.IsNullOrEmpty(NewNameOfProductFromAddWindow))
                    {
                        MessageBox.Show("Праверьте правильность названия товара ");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(NewInfoOfProductFromAddWindow))
                        {
                            MessageBox.Show("Праверьте правильность инфморации");

                        }
                        else
                        {
                            if (string.IsNullOrEmpty(NewCostOfProductFromAddWindow.ToString()))
                            {
                                MessageBox.Show("Праверьте правильность ввода цены");
                            }
                            else
                            {
                                if (NewCostOfProductFromAddWindow >= 10000)
                                {
                                    MessageBox.Show("Цена не может превышать 10 тысяч");
                                }
                                else
                                {
                                    if (NewCostOfProductFromAddWindow == 0)
                                    {
                                        MessageBox.Show("Цена не может быть равно 0");
                                    }
                                    else
                                    {
                                        Products products = unitOfWork.ProductsRepository.GetAllObjectInList()
                                        .Where(us => us.NameOfProduct == NewNameOfProductFromAddWindow)
                                        .FirstOrDefault();

                                        if (products != null)
                                        {
                                            MessageBox.Show("Такой продукт уже существует,придумайте другое название");

                                        }
                                        else
                                        {
                                            unitOfWork.ProductsRepository.Create(new Products(NewNameOfProductFromAddWindow, NewInfoOfProductFromAddWindow,
                                            NewCostOfProductFromAddWindow, LoginNamespace.Logins.login));
                                            unitOfWork.Save();
                                            MessageBox.Show("Товар успешно добавлен");
                                        }
                                    }
                                }
                            }
                        }

                    }
                });
            }
        }

        public ICommand AddNewProductToWindow
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    ViewController view = ViewController.GetInstance();
                    AddNewProductWindow addWindow = new AddNewProductWindow();
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

        public ICommand ChangeProductCommandFromWindow
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    try
                    {
                        if (string.IsNullOrEmpty(ChangeNameOfProductFromWindow))
                        {
                            MessageBox.Show("Праверьте правильность изменения названия товара");
                        }
                        else
                        {
                            if (ChangeNameOfProductFromWindow.Length >= 25)
                            {
                                MessageBox.Show("Длинна названия слишком большая уложитесь в 25 символов");
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(ChangeInfoOfProductFromWindow))
                                {
                                    MessageBox.Show("Праверьте правильность изменения информации о товаре ");

                                }
                                else
                                {
                                    if (ChangeInfoOfProductFromWindow.Length >= 100)
                                    {
                                        MessageBox.Show("Длинна информации не может привышать 100 символов");
                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(ChangeCostOfProductFromWindow.ToString()))
                                        {
                                            MessageBox.Show("Праверьте правильность изменения цены");

                                        }
                                        else
                                        {
                                            if (ChangeCostOfProductFromWindow >= 10000)
                                            {
                                                MessageBox.Show("Цена не может привышать 10000 б.р");
                                            }
                                            else
                                            {
                                                if (ChangeCostOfProductFromWindow == 0 )
                                                {
                                                    MessageBox.Show("Цена не может быть равной 0 ");
                                                }
                                                else
                                                {
                                                    unitOfWork.ProductsRepository.Create(new Products(ChangeNameOfProductFromWindow, ChangeInfoOfProductFromWindow,
                                                        ChangeCostOfProductFromWindow, LoginNamespace.Logins.login));
                                                    unitOfWork.Save();
                                                    MessageBox.Show("Продукт успешно изменен");
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
        private void ChangeProductMethod(object parameter)
        {
            if (parameter is Products products)
            {
                ItemsForProductsBox.Remove(products);
                unitOfWork.ProductsRepository.Delete(products);
                unitOfWork.Save();
                OnPropertyChanged("ItemsForProductsBox");
                ViewController view = ViewController.GetInstance();
                ChangeProductWindow editWindow = new ChangeProductWindow();
                view.CloseAndShow(editWindow);
            }
        }
       
        public ICommand BackCmd
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    if (string.IsNullOrEmpty(ChangeInfoOfProductFromWindow) || string.IsNullOrEmpty(ChangeCostOfProductFromWindow.ToString())
                    || string.IsNullOrEmpty(ChangeNameOfProductFromWindow.ToString()))
                    {
                        MessageBox.Show("Внесите изменения прежде чем выйти");
                    }
                    else
                    {
                        ViewController view = ViewController.GetInstance();
                        AdminProductsWindow admWindow = new AdminProductsWindow();
                        view.CloseAndShow(admWindow);
                    }

                });
            }
        }
        private void RemoveMetod(object parameter)
        {
            if (parameter is Products item)
            {
                ItemsForProductsBox.Remove(item);
                unitOfWork.ProductsRepository.Delete(item);
                unitOfWork.Save();
                OnPropertyChanged("ItemsForProductsBox");
                MessageBox.Show("Объект успешно удален");
            }
        }

        private void ShowProductInfoMetod(object parameter)
        {
            if (parameter is Products products)
                MessageBox.Show($"{products.Info}\n"+
                    $"Добавил - {products.WhoAddProduct}");
        }  
    }
}
