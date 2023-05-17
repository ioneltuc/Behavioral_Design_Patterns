namespace TMPS_lab3.State
{
    public class StandardState : ProductState
    {
        public StandardState(Product product) : base(product)
        {
        }

        public override void PutProductOnClearanceSale()
        {
            Product.Discount = 50;
            Product.Price = (Product.Price * (100 - Product.Discount)) / 100;
            Console.WriteLine($"Clearance sale:\n" +
                $"\tPrice: {Product.Price} lei\n" +
                $"\tDiscount: {Product.Discount}%\n");
            Product.ChangeState(new ClearanceSaleState(Product));
        }

        public override void PutProductOnSale()
        {
            Product.Discount = 30;
            Product.Price = (Product.Price * (100 - Product.Discount)) / 100;
            Console.WriteLine($"Sale:\n" +
                $"\tPrice: {Product.Price} lei\n" +
                $"\tDiscount: {Product.Discount}%\n");
            Product.ChangeState(new DiscountState(Product));
        }

        public override void RemoveProductDiscount()
        {
            Console.WriteLine("This product does not even have a discount.\n");
        }
    }
}