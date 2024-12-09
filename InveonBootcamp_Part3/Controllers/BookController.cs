using InveonBootcamp_Part3.Dtos;
using InveonBootcamp_Part3.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using StackExchange.Redis;
using System.Linq.Expressions;
using System.Text.Json;

namespace InveonBootcamp_Part3.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class BookController(IBookService bookService, IConnectionMultiplexer redisConnection) : ControllerBase
    {
        private const string CacheKey = "AllBooks";

        [HttpGet("AllBooks")]
        public async Task<IActionResult> GetAllBooks()
        {

            //if(memoryCache.TryGetValue(CacheKey, out List<Book> cachedBook)){
            //    return Ok(new { data = cachedBook, source = "cache" });

            //}
            var redisDatabase = redisConnection.GetDatabase();

            var cachedBooks = await redisDatabase.StringGetAsync(CacheKey);
            if (cachedBooks.HasValue)
            {
                var booksFromCache = JsonSerializer.Deserialize<List<Book>>(cachedBooks);

                return Ok(new { source = "Redisten getir", books = booksFromCache });
            }
            
            var books =  await bookService.GetBooks();

            var bookJ = JsonSerializer.Serialize(books);
            await redisDatabase.StringSetAsync(CacheKey, bookJ, TimeSpan.FromMinutes(5));

            //memoryCache.Set(CacheKey, books, TimeSpan.FromMinutes(5));

            return Ok(books);

        }

        [HttpGet("AllBooksPagination")]
        public async Task<IActionResult> GetAllBooksPaged(int pageIndex, int pageSzie)
        {

            var skip = (pageIndex - 1) * pageSzie;


            var redisDatabase = redisConnection.GetDatabase();

            var cachedBooks = await redisDatabase.StringGetAsync(CacheKey);
            if (cachedBooks.HasValue)
            {
                var booksFromCache = JsonSerializer.Deserialize<List<Book>>(cachedBooks);
                var pagedBooksCache = booksFromCache
                    .Skip(skip)
                    .Take(pageSzie)
                    .ToList();

                var totalRecordsCache = booksFromCache.Count;
                var totalPagesCache = (int)Math.Ceiling(totalRecordsCache / (double)pageSzie);

                return Ok(
                new {
                    Source = "Redisten getir",
                    CurrentPage = pageIndex,
                    PageSize = pageSzie,
                    TotalPages = totalPagesCache,
                    TotalRecords = totalRecordsCache,
                    Data = booksFromCache
                });
            }

            var books = await bookService.GetBooks();

            var bookJ = JsonSerializer.Serialize(books);
            await redisDatabase.StringSetAsync(CacheKey, bookJ, TimeSpan.FromMinutes(5));

            var pagedBooks = books
                .Skip(skip)
                .Take(pageSzie)
                .ToList();

            var totalRecords = books.Count;
            var totalPages = (int)Math.Ceiling(totalRecords / (double)pageSzie);

            return Ok(new
            {
                CurrentPage = pageIndex,
                PageSize = pageSzie,
                TotalPages = totalPages,
                TotalRecords = totalRecords,
                Data = pagedBooks
            });

            //return Ok(books);

        }

        //Hata yönetim sistemini buraya uyguladım (ProblemDetails)
        [HttpGet("{id}")]
        public async Task<IActionResult> SelectBook(int id)
        {
            var books = bookService.GetBookByIdReturnServiceResult(id);

            return Ok(books);

        }

        [HttpPost]
        public async Task<IActionResult> CreateBook(BookDto book)
        {
            var addedBook = await bookService.CreateBook(book);

            return Created();
        }

        [HttpPost("CreateBookServiceResult")]
        public async Task<IActionResult> CreateBookReturnServiceResult(BookDto book)
        {
            var addedBook = bookService.CreateBookReturnServiceResult(book);

            return Created();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id)
        {
            //var updateBook =;

            return NoContent();

        }
    }
}
