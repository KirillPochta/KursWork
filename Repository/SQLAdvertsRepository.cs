using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.Repository
{
    public class SQLAdvertsRepository:IRepository<Advert>
    {
        private UserContext db;

        public SQLAdvertsRepository(UserContext context)
        {
            this.db = context;
        }

        public IEnumerable<Advert> GetAllObjectInList()
        {
            return db.AdvertsSet;
        }

        public Advert GetObject(int id)
        {
            return db.AdvertsSet.Find(id);
        }

        public void Create(Advert obj)
        {
            db.AdvertsSet.Add(obj);
        }

        public void Update(Advert obj)
        {
            db.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(Advert obj)
        {
                db.AdvertsSet.Remove(obj);
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
        public IEnumerable<Advert> GetItemList()
        {
            return db.AdvertsSet.ToList();
        }
    }
}
