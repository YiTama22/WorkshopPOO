namespace WorkshopPOO
{
    public class FixedPriceProduct : Product
    {   


        public override decimal ValueToPay()
        {
            decimal value = (Price * (decimal)Tax) + (Price);
            return value;
        }
        public override string ToString()
        {
            return $"  {Id} {Description}" +
                base.ToString() +
                $"\n\tValue......:{$"{ValueToPay():C2}",13}";
        }
    }
}
