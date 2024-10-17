using Task.Exceptions;

namespace Task.Models
{
    internal class Library
    {
        public Library(int bookLimit)
        {
            BookLimit = bookLimit;
            Books = new List<Book>();
        }
        public int BookLimit { get; set; }
        private List<Book> Books { get; set; }
        //Book book = null;
        public void AddBook(Book book)
        {
            try
            {
                if (Books.Count+1 > BookLimit)
                {
                    throw new CapacityLimitException("Book limit exception");
                }

                Books.Add(book);
                Console.WriteLine(book.Name + " added");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


        }
        public Book GetBookById(int? id)
        {
            try
            {
                if (id is null) { throw new NullReferenceException("id is null"); }
                var book = Books.Find(i => i.Id == id);
                if (book == null)
                    return null;
                return book;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
         
        }
        public void RemoveById(int? id)
        {
            try
            {
                if (id is null) { throw new NullReferenceException("id is null"); }
                var book = Books.Find(i => i.Id == id);

                if (book == null)
                    throw new NotFoundException("Not Found");

                Books.Remove(book);
                Console.WriteLine($"Book with ID {id} removed successfully.");

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); ;
            }

        }
        public void GetAllBooks()
        {
            if (Books.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            foreach (Book book in Books)
            {
                Console.WriteLine($"ID: {book.Id}, Name: {book.Name}");
            }
        }


    }
}
