using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Repository
{
    public class UnitOfWork : IDisposable
    {
        private UserContext db = new UserContext();
        private SQLAdvertsRepository advertRepository;
        private SQLProductsRepository productRepository;
        private SQLPurchaseHistoryRepository purchaseHistoryRepository;
        private SQLUsersRepository usersRepository;

        public SQLAdvertsRepository AdvertsRepository
        {
            get
            {
                if (advertRepository == null)
                    advertRepository = new SQLAdvertsRepository(db);
                return advertRepository;
            }
        }
        public SQLProductsRepository ProductsRepository
        {
            get
            {
                if (productRepository == null)
                    productRepository = new SQLProductsRepository(db);
                return productRepository;
            }
        }

        public SQLPurchaseHistoryRepository PurchasesHistoryRepository
        {
            get
            {
                if (purchaseHistoryRepository == null)
                    purchaseHistoryRepository = new SQLPurchaseHistoryRepository(db);
                return purchaseHistoryRepository;
            }
        }
        public SQLUsersRepository UsersRepository
        {
            get
            {
                if (usersRepository == null)
                    usersRepository = new SQLUsersRepository(db);
                return usersRepository;
            }
        }
      

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
