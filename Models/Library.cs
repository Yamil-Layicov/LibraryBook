using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork1.Models
{
    class Library
    {
        private List<Book> _books;
        public List<Book> Books => _books;

        public Library()
        {
            _books = new List<Book>();
        }

        public void Add(Book book)
        {

            _books.Add(_books.Find(b => b.Name == book.Name) == null ? book : throw new SameBookalreadyAddedExpection("Book with This Name, Already Added!");

        }
    }
}
