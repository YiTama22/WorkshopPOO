using System.Collections;

namespace WorkshopPOO
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public ICollection Products { get; set; }


        public override decimal ValueToPay()
        {
            decimal comboValue = 0;
            foreach (Product product in Products)
            {
                comboValue += product.ValueToPay();
            }
            decimal totalDiscount = comboValue * (decimal)Discount;

            decimal promotionValue = comboValue - totalDiscount;
            return promotionValue;
        }
        public override string ToString()
        {
            string description = "";
            foreach (Product product in Products)
            {

                description += product.Description + ", ";
            }

            return $"  {Id} {Description}" +
                   $"\n\tProducts...: {description:C2}" +
                   $"\n\tDiscount...: {$"{Discount:P2}",12}" +
                   $"\n\tValue......: {$"{ValueToPay():C2}",12}";
        }
    }
}
