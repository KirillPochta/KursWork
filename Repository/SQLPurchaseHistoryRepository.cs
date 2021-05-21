using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.Repository
{
    public class SQLPurchaseHistoryRepository :IRepository<PurchaseHistory>
    {
        private UserContext db;

        public SQLPurchaseHistoryRepository(UserContext context)
        {
            this.db = context;
        }

        public IEnumerable<PurchaseHistory> GetAllObjectInList()
        {
            return db.PurchasesSet;
        }

        public PurchaseHistory GetObject(int id)
        {
            return db.PurchasesSet.Find(id);
        }

        public void Create(PurchaseHistory obj)
        {
            db.PurchasesSet.Add(obj);
        }

        public void Update(PurchaseHistory obj)
        {
            db.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(PurchaseHistory obj)
        {
            db.PurchasesSet.Remove(obj);
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
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public IEnumerable<PurchaseHistory> GetItemList()
        {
            return db.PurchasesSet.ToList();
        }

    }
}
