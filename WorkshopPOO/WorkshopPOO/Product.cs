namespace WorkshopPOO
{
    public abstract class Product : Ipay
    {

        public string Description { get; set; }
        public int Id { get; set; }
        public decimal Price { get; set; }
        public float Tax { get; set; }

        public override string ToString()
        {
            return $"\n\tPrice......:{$"{Price:C2}",13}" +
                   $"\n\tTax........:{$"{Tax:P2}",13}";

        }
        public abstract decimal ValueToPay();
    }
}
