namespace TMPS_lab3.Observer
{
    public class Order
    {
        public List<Product> Products { get; set; }

        public Order()
        {
            Products = new List<Product>();
        }
    }
}