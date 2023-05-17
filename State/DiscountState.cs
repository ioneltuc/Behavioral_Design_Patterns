namespace TMPS_lab3.State
{
    public class DiscountState : ProductState
    {
        public DiscountState(Product product) : base(product)
        {
        }

        public override void RemoveProductDiscount()
        {
            Product.Price = (Product.Price * 100) / (100 - Product.Discount);
            Product.Discount = 0;
            Console.WriteLine($"No sale:\n" +
                $"\tPrice: {Product.Price} lei\n" +
                $"\tDiscount: {Product.Discount}%\n");
            Product.ChangeState(new StandardState(Product));
        }

        public override void PutProductOnSale()
        {
            Console.WriteLine($"The product is already on sale.\n" +
                $"Discount is {Product.Discount}% and product price is {Product.Price} lei\n");
        }

        public override void PutProductOnClearanceSale()
        {
            Product.Price = (Product.Price * 100) / (100 - Product.Discount);
            Product.Discount = 50;
            Product.Price = (Product.Price * (100 - Product.Discount)) / 100;
            Console.WriteLine($"Clearance sale:\n" +
                $"\tPrice: {Product.Price} lei\n" +
                $"\tDiscount: {Product.Discount}%\n");
            Product.ChangeState(new ClearanceSaleState(Product));
        }
    }
}