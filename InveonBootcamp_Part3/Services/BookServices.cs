using InveonBootcamp_Part3.Dtos;
using InveonBootcamp_Part3.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InveonBootcamp_Part3.Services
{
    public class BookServices(IBookRepository bookRepository) : IBookService
    {

        public async Task<List<Book>> GetBooks()
        {
            var books = await bookRepository.GetAll();


            var bookRet = books.Select(x => new BookDto(x.Id,x.Title, x.Author, x.Name, x.Description) { }).ToList();


            return books;
        }

        public ServiceResult GetBooksReturnServiceResult()
        {
            var books = bookRepository.GetAll();

            if (books != null)
            {
                return new ServiceResult<List<Book>>
                {
                    Data = books
                };
            }
            
            return new ServiceResult
            {
                ProblemDetails = new ProblemDetails
                {
                    Status = 404,
                    Detail = "Hiçbir kitap bulunamadı"
                }
                
            };
        }


        public async Task<BookDto> SelectBook(int? id = null)
        {
            var filteredBooks = await bookRepository.SelectBook(id);

            if (filteredBooks != null)
            {
                return new BookDto(filteredBooks.Id,filteredBooks.Title, filteredBooks.Author, filteredBooks.Name, filteredBooks.Description);
            }

            return null;
        }


        public ServiceResult GetBookByIdReturnServiceResult(int id)
        {
            //BookDto(filteredBooks.Id, filteredBooks.Title, filteredBooks.Author, filteredBooks.Name, filteredBooks.Description);
            var filteredBooks = bookRepository.SelectBook(id);

            if (filteredBooks != null)
            {
                return new ServiceResult<Book>
                {
                    Data = filteredBooks
                };
            }

            return new ServiceResult<Book>
            {
                ProblemDetails = new ProblemDetails
                {
                    Status = 404,
                    Detail = "Bu id 'de ürün bulunamadı"
                }
            };
        }

        public async Task<BookDto> CreateBook(BookDto book)
        {
            var addBook = new Book(book.Id, book.Title, book.Author, book.Name, book.Description);

            var newbook = bookRepository.AddBook(addBook);

            return book;
        }

        public ServiceResult CreateBookReturnServiceResult(BookDto book)
        {
            try
            {
                var addBook = new Book(book.Id, book.Title, book.Author, book.Name, book.Description);

                var newbook = bookRepository.AddBook(addBook);

                return new ServiceResult<Book>
                {
                    Data = newbook
                };
            }
            catch (Exception error)
            {
                return new ServiceResult
                {
                    ProblemDetails = new ProblemDetails
                    {
                        Status = 500,
                        Detail = error.Message
                    }
                };
            }
        }
    }
}
