namespace WorkshopPOO
{
    public class Invoice : Ipay
    {
        private ICollection<Product> _Products = new List<Product>();
        public Invoice()
        {

        }


        public void AddProduct(Product productInvoce)
        {
             _Products.Add(productInvoce);
        }
        public override string ToString()
        {
            object totalProductsToPayInvoice;
            string stringTotalProductsToPayInvoice = "";
            foreach (Product product in _Products)
            {
                totalProductsToPayInvoice = product;
                stringTotalProductsToPayInvoice += $"\n{totalProductsToPayInvoice}";
            }

            return $" RECEIPT"
                + $"\n ------------------------------------------------"
                + $"{stringTotalProductsToPayInvoice}"
                + $"\n                    ============="
                + $"\n TOTAL:              {$"{ValueToPay():C2}",12}";
        }
        public decimal ValueToPay()
        {
            decimal totalValueToPayInvoice = 0;
            foreach (Product product in _Products)
            {
                totalValueToPayInvoice += product.ValueToPay();

            }
            return totalValueToPayInvoice;
        }
    }
}
