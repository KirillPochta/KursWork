using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Repository
{
    public class SQLUsersRepository :IRepository<User>
    {
        private UserContext db;

        public SQLUsersRepository(UserContext context)
        {
            this.db = context;
        }

        public IEnumerable<User> GetAllObjectInList()
        {
            return db.Users;
        }

        public User GetObject(int id)
        {
            return db.Users.Find(id);
        }

        public void Create(User user)
        {
            db.Users.Add(user);
        }

        public void Update(User user)
        {
            db.Entry(user).State = EntityState.Modified;
        }
        
        public void Delete(User user)
        {
            db.Users.Remove(user);
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
        public IEnumerable<User> GetItemList()
        {
            return db.Users.ToList();
        }
    
    }
}
