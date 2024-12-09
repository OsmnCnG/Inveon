using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InveonBootcamp_Part3
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }


        public Book(int id, string title, string author, string name, string description)
        {
            Id = id;
            Title = title;
            Author = author;
            Name = name;
            Description = description;
        }

        public DateTime CreatedDate()
        {
            return DateTime.Today;
        }
    }
}
