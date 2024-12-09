using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InveonBootcamp_Part3.Dtos
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }

        public BookDto(int id,string title, string author, string name, string description)
        {
            Id = id;
            Title = title;
            Author = author;
            Name = name;
            Description = description;
        }
    }
}
