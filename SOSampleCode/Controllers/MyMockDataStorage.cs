using System.Collections.Generic;
using System.Linq;
using SOSampleCode.Models;

namespace SOSampleCode.Controllers
{
    public static class MyMockDataStorage
    {
        private static readonly List<Book> _books=new List<Book>();
        public static void Add(Book book)
        {
            _books.Add(book);
        }
        public static void Remove(Book book)
        {
            var b=_books.FirstOrDefault(a => a.BookName == book.BookName);
            _books.Remove(b);
        }

        public static List<Book> GetAll()
        {
            return _books;
        }
    }
}