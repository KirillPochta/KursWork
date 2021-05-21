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
using WpfApp1.Repository;

namespace WpfApp1.ViewModels
{
    public class AdminPurchaseHistoryVm:OnPropertyChangedClass
    {
        public string SearchInfoBylogin { get; set; }
        public string ByWhichSort { get; set; }

        public ObservableCollection<PurchaseHistory> ItemsForPurchaseHistoryBox { get; set; }
        public ObservableCollection<PurchaseHistory> ItemsForPurchaseHistoryBox1 { get; set; }
        readonly UnitOfWork unitOfWork;
        private RelayCommand _showСhequeOfProduct;

        public AdminPurchaseHistoryVm()
        {
            unitOfWork = new UnitOfWork();
        
            ItemsForPurchaseHistoryBox = new ObservableCollection<PurchaseHistory>
                (unitOfWork.PurchasesHistoryRepository.GetAllObjectInList());
        }

        public RelayCommand ShowСhequeOfProductCommand => _showСhequeOfProduct ?? (_showСhequeOfProduct = new RelayCommand(ShowChequeInfoMetod));

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
        public ICommand MadeASortByLogin
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    ItemsForPurchaseHistoryBox.Clear();
                    ItemsForPurchaseHistoryBox = new ObservableCollection<PurchaseHistory>(unitOfWork.PurchasesHistoryRepository.GetAllObjectInList()
                       .OrderByDescending(i => i.LoginOfBuyer));
                    OnPropertyChanged("ItemsForPurchaseHistoryBox");
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


        private void ShowChequeInfoMetod(object parameter)
        {
            if (parameter is PurchaseHistory purchaseHistory)
            {
               
                MessageBox.Show($"Покупка выполнена пользователем - {purchaseHistory.LoginOfBuyer} \n" +
                    $"Дата покупки - {purchaseHistory.Dt} \n" +
                    $"Количество приоьретенного - {purchaseHistory.Count} \n" +
                    $"К Оплате (б.р) - {purchaseHistory.ForPayment} \n" +
                    $"Информация о товаре - \n{purchaseHistory.InfoOfPurchasesProduct} \n" +
                    $"Идентификатор чека - {purchaseHistory.IdOfPurchases}");
            }
        }
    }
}

