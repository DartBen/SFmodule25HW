using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFmodule25HW.Repository
{
    //в которых опишите следующие действия: выбор объекта из БД по его идентификатору, выбор всех объектов, добавление объекта в БД и его удаление из БД.
    //А также специфичные методы: обновление имени пользователя(по Id) и обновление года выпуска книги(по Id).
    public interface IRepository<T>
    {
        T GetById(int id);
        List<T> GetAll();
        void CreateNewRecord(T record);
        void DeleteById(int id);
    }
}
