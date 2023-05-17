namespace TMPS_lab3.State
{
    public class ClearanceSaleState : ProductState
    {
        public ClearanceSaleState(Product product) : base(product)
        {
        }

        public override void PutProductOnClearanceSale()
        {
            Console.WriteLine($"The product is already on clearance sale.\n" +
                $"Discount is {Product.Discount}% and product price is {Product.Price} lei\n");
        }

        public override void PutProductOnSale()
        {
            Console.WriteLine("The discount cannot be reduced from the products that are on clearance sale.\n");
        }

        public override void RemoveProductDiscount()
        {
            Console.WriteLine("The discount cannot be removed from the products that are on clearance sale.\n");
        }
    }
}