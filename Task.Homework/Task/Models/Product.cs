namespace Task.Models
{
    internal abstract class Product
    {
        protected Product()
        {
            _id++;
            Id=_id;
            //Console.WriteLine(Id+" ");
        }
        private static int _id=0;
        public int Id{ get; private set; }
        public string Name{ get; set; }
        public decimal Price{ get; set; }
        public int Count{ get; set; }
        public decimal ToatlInCome{ get; set; }
        public abstract void Sell();
        public abstract void ShowInfo();

    }
}
