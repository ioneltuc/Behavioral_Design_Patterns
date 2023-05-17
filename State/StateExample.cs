namespace TMPS_lab3.State
{
    public static class StateExample
    {
        public static void StartExample()
        {
            var product = new Product("Pants", "Blue jeans", 1000);

            product.RemoveProductDiscount();
            product.PutProductOnSale();
            product.RemoveProductDiscount();
            product.PutProductOnSale();
            product.PutProductOnSale();
            product.PutProductOnClearanceSale();
            product.RemoveProductDiscount();
            product.PutProductOnSale();
        }
    }
}