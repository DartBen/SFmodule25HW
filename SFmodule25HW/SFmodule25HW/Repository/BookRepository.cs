using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFmodule25HW.Repository;
using SFmodule25HW.AppContext;

namespace SFmodule25HW.Repository
{
    public class BookRepository : IRepository<Book>, IBookRepository
    {
        private AppContext.AppContext DB;

        public BookRepository(AppContext.AppContext appContext)
        {
            DB = appContext;
        }
        public void CreateNewRecord(Book record)
        {
            DB.Books.Add(record);
            DB.SaveChanges();
        }

        public void DeleteById(int id)
        {
            DB.Books.Remove(DB.Books.FirstOrDefault(u => u.Id == id));
            DB.SaveChanges();
        }

        public List<Book> GetAll()
        {
            try
            {
                return DB.Books.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public Book GetById(int id)
        {
            return DB.Books.FirstOrDefault(u => u.Id == id);
        }

        public void UpdateReleaseYearById(int id, int year)
        {
            var book = GetById(id);
            book.releaseYear = year;
            DB.SaveChanges();
        }
    }

    public interface IBookRepository
    {
        void UpdateReleaseYearById(int id, int year);
    }
}
