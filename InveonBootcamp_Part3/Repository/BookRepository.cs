using InveonBootcamp_Part3;
using InveonBootcamp_Part3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InveonBootcamp_Part3.Repository
{
    public class BookRepository : IBookRepository
    {

        private readonly List<Book> books= new();

        public Task Add(Book book)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Book>> GetAll()
        {
            var books = new List<Book>
        {
            new Book(1,"Title", "GMartin", "A Dance with Dragons", "House of the dragon series"),
            new Book(2,"Title", "GMartin", "The Winds of Winter", "House of the dragon series"),
            new Book(3,"Title", "GMartin", "A Dance with Dragons", "House of the dragon series"),
            new Book(4,"Title", "GMartin", "The Winds of Winter", "House of the dragon series")
        };

            return Task.FromResult(books);
        }




        public async Task<Book> SelectBook(int? id = null)
        {
            var books = new List<Book>
            {
                new Book(1,"Title", "GMartin", "A Dance with Dragons", "House of the dragon series"),
                new Book(2,"Title", "GMartin", "The Winds of Winter", "House of the dragon series"),
                new Book(3,"Title", "GMartin", "A Dance with Dragons", "House of the dragon series"),
                new Book(4,"Title", "GMartin", "The Winds of Winter", "House of the dragon series")
            };

            if (id != null)
            {
                return await Task.FromResult(books.Find(s=>s.Id==id));
            }
            else
            {
                return await Task.FromResult(books.FirstOrDefault());

            }

        }

        public Task<Book> AddBook(Book book)
        {
            books.Add(book);
            return Task.FromResult(book);
        }


        public Task<Book> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
