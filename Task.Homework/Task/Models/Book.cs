using Task.Exceptions;

namespace Task.Models
{
    internal class Book : Product
    {
        public Book(string name,decimal price,string authorName, int pageCount)
        {
            Name = name;
            Price = price;
            AuthorName = authorName;
            PageCount = pageCount;
            Count++;
        }

        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public override void Sell()
        {
            try
            {
                if (Count > 0)
                {
                    Count--;
                    ToatlInCome += Price;
                }
                else
                {
                    throw new ProductCountIsZeroException("No book");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); ;
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Id:{Id} \nName:{Name} \nPrice:{Price} \nAuthorName:{AuthorName} \nPageCount:{PageCount} \nCount:{Count} \nTotalInCome:{ToatlInCome}");
        }
    }
}
