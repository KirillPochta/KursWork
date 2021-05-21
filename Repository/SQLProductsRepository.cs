using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.Repository
{
    public class SQLProductsRepository:IRepository<Products>
    {
        private UserContext db;

        public SQLProductsRepository(UserContext context)
        {
            this.db = context;
        }

        public IEnumerable<Products> GetAllObjectInList()
        {
            return db.ProductsSet;
        }

        public Products GetObject(int id)
        {
            return db.ProductsSet.Find(id);
        }

        public void Create(Products user)
        {
            db.ProductsSet.Add(user);
        }

        public void Update(Products user)
        {
            db.Entry(user).State = EntityState.Modified;
        }

        public void Delete(Products obj)
        {
            db.ProductsSet.Remove(obj);
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
        public IEnumerable<Products> GetItemList()
        {
            return db.ProductsSet.ToList();
        }
    }
}
