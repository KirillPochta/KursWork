using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Repository
{
    interface IRepository<T> : IDisposable
        where T : class
    {
        IEnumerable<T> GetAllObjectInList(); // получение всех объектов
        T GetObject(int id); // получение одного объекта по id
        void Create(T item); // создание объекта
        void Update(T item); // обновление объекта
        void Delete(T item); // удаление объекта по 
        void Save();  // сохранение изменений
        IEnumerable<T> GetItemList();  // подгрузка данных из бд
    }
}
