namespace Task.Exceptions
{
    public class ProductCountIsZeroException:Exception
    {
        public ProductCountIsZeroException(string message):base(message) { }    
    }
}
