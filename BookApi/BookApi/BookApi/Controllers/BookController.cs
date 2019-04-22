using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly BookContext _context;

        public BookController(BookContext context)
        {

            _context = context;

            if (_context.Book.Count() == 0)
            {

                context.Book.AddRange(
                 new Book
                 {

                     Name = "Python编程 从入门到实践",
                     ReleaseDate = DateTime.Parse("2018-1-12"),
                     Author = "埃里克·马瑟斯",
                     Price = 75.99M,
                     Publishing = "机械出版社"
                 },

                 new Book
                 {

                     Name = "Java编程的逻辑",
                     ReleaseDate = DateTime.Parse("2018-1-13"),
                     Author = "马俊昌",
                     Price = 48.50M,
                     Publishing = "机械出版社"
                 },

                 new Book
                 {

                     Name = "统计思维:大数据时代瞬间洞察因果的关键技能",
                     ReleaseDate = DateTime.Parse("2017-12-23"),
                     Author = "西内启",
                     Price = 39.00M,
                     Publishing = "清华出版社"
                 },

                 new Book
                 {

                     Name = "微信营销",
                     ReleaseDate = DateTime.Parse("2018-01-05"),
                     Author = "徐林海",
                     Price = 36.90M,
                     Publishing = "清华出版社"
                 },

                    new Book
                    {

                        Name = "Java 8实战",
                        ReleaseDate = DateTime.Parse("2016-04-05"),
                        Author = "厄马",
                        Price = 65.60M,
                        Publishing = "科技出版社"
                    }
             );
                _context.SaveChanges();

            }
        }

        // GET: api/Book
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBookItems()
        {
            return await _context.Book.ToListAsync();
        }

        // GET: api/Book/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBookItem(int id)
        {
            var bookItem = await _context.Book.FindAsync(id);

            if (bookItem == null)
            {
                return NotFound();
            }
            return bookItem;
        }

    }
}