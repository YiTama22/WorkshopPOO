namespace WorkshopPOO
{
    public class VariablePriceProduct : Product
    {
        public float Quantity { get; set; }

        public string Measurement { get; set; }
        public override decimal ValueToPay()
        {
            return ((decimal)Tax * (Price * (decimal)Quantity)) + (Price * (decimal)Quantity);
        }
        public override string ToString()
        {
            return $"  {Id} {Description}" +
                   $"\n\tMeasurement: {Measurement}" +
                   $"\n\tQuantity...:{$"{Quantity:N2}",13}" +
                   $"{base.ToString()}" +
                   $"\n\tValue......:{$"{ValueToPay():C2}",13}";
        }
    }
}
