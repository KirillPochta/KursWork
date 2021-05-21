using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp1;
using WpfApp1.Models;
using WpfApp1.ViewModels;
using WpfApp1.Views;
using WpfApp1.Repository;

namespace ViewModels
{
    public class UserMainWindowVM:OnPropertyChangedClass
    {
        public ObservableCollection<Advert> ItemForListBox { get; set; }

        readonly UnitOfWork unitOfWork;
        public Advert SelectetListBoxItem { get; set; }

        public string NameOfadvertFromAddWindow { get; set; }
        public string ContentOfadvertFromAddWindow { get; set; }
        public string AuthorOfadvertFromAddWindow { get; set; }

     

       
        private RelayCommand _showContent;
   

        public UserMainWindowVM()
        {
            unitOfWork = new UnitOfWork();
            ItemForListBox = new ObservableCollection<Advert>(unitOfWork.AdvertsRepository.GetAllObjectInList());
            OnPropertyChanged("ItemForListBox");
        }

        public RelayCommand ShowContentCommand => _showContent ?? (_showContent = new RelayCommand(ShowContentMetod));

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
                    UserCabinet adminCabWindow = new UserCabinet();
                    view.CloseAndShow(adminCabWindow);

                });
            }
        }
        public ICommand MoveToTheUsersProductWindow
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    ViewController view = ViewController.GetInstance();
                    UserProductsWindow adminProductsWindow = new UserProductsWindow();
                    view.CloseAndShow(adminProductsWindow);
                });
            }
        }


        
        public ICommand MoveToTheUserProductsWindow
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    ViewController view = ViewController.GetInstance();
                    UserProductsWindow authWindow = new UserProductsWindow();
                    view.CloseAndShow(authWindow);

                });
            }
        }
        private void ShowContentMetod(object parameter)
        {
            if (parameter is Advert advert)
                MessageBox.Show(advert.Content + "\n" + "Автор - "+advert.Author);
        }
    }
}
