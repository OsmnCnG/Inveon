using InveonBootcamp_Part3.Dtos;
using InveonBootcamp_Part3.Repository;
using InveonBootcamp_Part3.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InveonBootcamp_Part3.Interfaces
{
    public interface IBookService
    {
        Task<List<Book>> GetBooks();

        Task<BookDto> SelectBook(int? id = null);

        Task<BookDto> CreateBook(BookDto book);

        ServiceResult CreateBookReturnServiceResult(BookDto book);

        ServiceResult GetBookByIdReturnServiceResult(int id);

        ServiceResult GetBooksReturnServiceResult();
    }
}
