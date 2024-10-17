


using Task.Models;

Book book = new Book("book",12,"au",12);
Book book2 = new Book("book",12,"au",12);

Library library = new Library(10);
library.GetAllBooks();
library.AddBook(book);
library.AddBook(book2);
var bookSearched=library.GetBookById(2);
library.RemoveById(2);

//Console.WriteLine(bookSearched.Name);
library.GetAllBooks();