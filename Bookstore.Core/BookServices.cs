using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace Bookstore.Core
{
    public class BookServices : IBookServices
    {
        private readonly IMongoCollection<Book> _books;
        public BookServices(IDbClient dbClient)
        {
           _books=dbClient.GetBooksCollection();
        }

        public Book AddBook(Book book)
        {
            _books.InsertOne(book);
            return book;
        }

        public void DeleteBook(string id)
        {
            _books.DeleteOne(book => book.BookId == id);
        }

        public Book GetBook(string id)
        {
            return _books.Find(book => book.BookId == id).FirstOrDefault();
        }

        public List<Book> GetBooks()
        {
            return _books.Find(book => true).ToList();
        }

        public Book UpdateBook(Book book)
        {
            GetBook(book.BookId);
            _books.ReplaceOne(b => b.BookId == book.BookId, book);
            return book; 
        }
    }
}
