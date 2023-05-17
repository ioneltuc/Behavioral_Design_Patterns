namespace TMPS_lab3.Observer
{
    public class MailMessage : ISubscriber
    {
        public string Update(Order order)
        {
            string productsInfo = string.Empty;

            foreach (Product product in order.Products)
            {
                productsInfo += $"\tName: {product.Name}\n" +
                    $"\tDescription: {product.Description}\n" +
                    $"\tPrice: {product.Price}\n\n";
            }

            string message = $"Your order has arrived at its destination.\n" +
                $"Order info:\n" +
                $"{productsInfo}" +
                $"\t\tTotal price: {order.Products.Sum(p => p.Price)}\n";

            Console.WriteLine($"=== Message by email ===\n{message}");

            return message;
        }
    }
}