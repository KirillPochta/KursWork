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
using WpfApp1.LoginNamespace;
using WpfApp1.Repository;

namespace WpfApp1.ViewModels
{
    class UserProductsWindowVm:OnPropertyChangedClass
    {
        public ObservableCollection<Products> ItemsForProductsBox {get; set;}

        readonly UnitOfWork unitOfWork;

        public Products SelectetListBoxItem { get; set; }

        private RelayCommand _showContent;
        private RelayCommand _changeAdvertCommand;

        public UserProductsWindowVm()
        {
            unitOfWork = new UnitOfWork();
            ItemsForProductsBox = new ObservableCollection<Products>(unitOfWork.ProductsRepository.GetAllObjectInList());
            OnPropertyChanged("ItemsForProductsBox");
        }

        public RelayCommand ShowInfoOfProductCommand => _showContent ?? (_showContent = new RelayCommand(ShowProductInfoMetod));
        public RelayCommand BuyProductCommand => _changeAdvertCommand ?? (_changeAdvertCommand = new RelayCommand(BuyProductMethod));

       

        public ICommand MoveToTheUserAdvertWindow
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    ViewController view = ViewController.GetInstance();
                    UserMainWindow adminMainWindow = new UserMainWindow();
                    view.CloseAndShow(adminMainWindow);

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
        public ICommand ReturnToTheUserCabinet
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    ViewController view = ViewController.GetInstance();
                    UserCabinet userCabWindow = new UserCabinet();
                    view.CloseAndShow(userCabWindow);

                });
            }
        }
      
        private void BuyProductMethod(object parameter)
        {
            if (parameter is Products products)
            {
                int Count = products.Count;
                if (Count == 0)
                {
                    MessageBox.Show("Перед покупкой укажите количество  товара для приобретения");
                }
                else
                {
                    if (Count > 1000)
                    {
                        MessageBox.Show("Максимальное колиество для приобретения 1000 л");
                    }
                    else
                    {
                        DateTime dateTime = DateTime.Today;
                        string LoginOfBuyer;
                        string NameOfBoughtProduct;
                        string InfoOfPurchasesProduct;
                        int Cost, ForPaymnet;
                        NameOfBoughtProduct = products.NameOfProduct;
                        InfoOfPurchasesProduct = products.Info;
                        Cost = products.Cost;
                        ForPaymnet = products.Count * products.Cost;
                        LoginOfBuyer = Logins.login;
                        Random rnd = new Random();
                        int rndd = rnd.Next(1000);

                        unitOfWork.PurchasesHistoryRepository.Create
                            (new PurchaseHistory(LoginOfBuyer, NameOfBoughtProduct, InfoOfPurchasesProduct, Cost, rndd, Count, ForPaymnet, dateTime));
                        unitOfWork.Save();
                        MessageBox.Show("Товар приобретен");
                    }
                }
            }
        }

        
      

        private void ShowProductInfoMetod(object parameter)
        {
            if (parameter is Products products)
                MessageBox.Show(products.Info);
        }
    }
}
