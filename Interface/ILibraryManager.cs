using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork1.Models
{
    interface ILibraryManager
    {
        public List <Book> Books { get; set; }

        public void Add(Book book);

        public Book ShowInfo(string name);

        public List<Book> Search(string search);

        public List<Book> Filter(string genre, string author);
    }
}
