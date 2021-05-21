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
using WpfApp1.ViewModels;
using WpfApp1.Views;
using WpfApp1.Repository;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace WpfApp1
{
    public class UserPurchasesHistoryWindowVm:OnPropertyChangedClass
    {
        public ObservableCollection<PurchaseHistory> ItemsForPurchaseHistoryBox { get; set; }

        readonly UnitOfWork unitOfWork;
        public PurchaseHistory InfoOfUsersPurchases;

        public string LoginOfBuyer
        {
            get
            {
                return InfoOfUsersPurchases.LoginOfBuyer;
            }
            set
            {
                InfoOfUsersPurchases.LoginOfBuyer = value;
            }
        }
        public string InfoOfPurchasesProduct
        {
            get
            {
                return InfoOfUsersPurchases.InfoOfPurchasesProduct;
            }
            set
            {
                InfoOfUsersPurchases.InfoOfPurchasesProduct = value;
            }
        }
        public int Cost
        {
            get
            {
                return InfoOfUsersPurchases.Cost;
            }
            set
            {
                InfoOfUsersPurchases.Cost = value;
            }
        }
        public int IdOfPurchases
        {
            get
            {
                return InfoOfUsersPurchases.IdOfPurchases;
            }
            set
            {
                InfoOfUsersPurchases.IdOfPurchases = value;
            }
        }


        private RelayCommand _showСhequeOfProduct;
        private RelayCommand _deletaProduct;

        public UserPurchasesHistoryWindowVm()
        {
            unitOfWork = new UnitOfWork();
            ItemsForPurchaseHistoryBox = new ObservableCollection<PurchaseHistory>
                (unitOfWork.PurchasesHistoryRepository.GetAllObjectInList().Where(us =>us.LoginOfBuyer == LoginNamespace.Logins.login));
            OnPropertyChanged("ItemsForPurchaseHistoryBox");
        }
        public RelayCommand ShowСhequeOfProductCommand => _showСhequeOfProduct ?? (_showСhequeOfProduct = new RelayCommand(ShowChequeInfoMetod));
        public RelayCommand DeletaProductCommand => _deletaProduct ?? (_deletaProduct = new RelayCommand(DeletaProductMethod));

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
        public ICommand MadeASortByName
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    ItemsForPurchaseHistoryBox.Clear();
                    ItemsForPurchaseHistoryBox = new ObservableCollection<PurchaseHistory>(unitOfWork.PurchasesHistoryRepository.GetAllObjectInList()
                       .OrderByDescending(i => i.NameOfBoughtProduct));
                    OnPropertyChanged("ItemsForPurchaseHistoryBox");
                });
            }
        }
        public ICommand MadeASortByIdPurchase
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    ItemsForPurchaseHistoryBox.Clear();
                    ItemsForPurchaseHistoryBox = new ObservableCollection<PurchaseHistory>(unitOfWork.PurchasesHistoryRepository.GetAllObjectInList()
                       .OrderByDescending(i => i.IdOfPurchases));
                    OnPropertyChanged("ItemsForPurchaseHistoryBox");
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
        private void ShowChequeInfoMetod(object parameter)
        { 
            if (parameter is PurchaseHistory purchaseHistory)
            {
                MessageBox.Show(
                    $"К Оплате (б.р) - {purchaseHistory.ForPayment} \n" +
                    $"Количество приобретенного (л) - {purchaseHistory.Count} \n" +
                    $"Дата приобретения {purchaseHistory.Dt} \n" +
                    $"Идентификатор чека {purchaseHistory.IdOfPurchases} \n" +
                    $"Информация о товаре - \n{purchaseHistory.InfoOfPurchasesProduct} \n" +
                    $"Для получения товара подъедьте к ул.Харьковская 81");
            }
        }
        private void DeletaProductMethod(object parameter)
        {
            if (parameter is PurchaseHistory purchaseHistory)
            {
                ItemsForPurchaseHistoryBox.Remove(purchaseHistory);
                unitOfWork.PurchasesHistoryRepository.Delete(purchaseHistory);
                unitOfWork.Save();
                OnPropertyChanged("ItemsForPurchaseHistoryBox");
                MessageBox.Show("Покупка успешно отменена");
            }
        }
    }
}

