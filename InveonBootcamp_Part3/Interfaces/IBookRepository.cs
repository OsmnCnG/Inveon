using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using InveonBootcamp_Part3;

namespace InveonBootcamp_Part3.Interfaces
{
    public interface IBookRepository
    {
        Task<Book> AddBook(Book book);
        Task<Book> GetById(int id);
        Task<List<Book>> GetAll();
        Task Update(Book book);
        Task Delete(int id);

        Task<Book> SelectBook(int? id = null);

    }
}
