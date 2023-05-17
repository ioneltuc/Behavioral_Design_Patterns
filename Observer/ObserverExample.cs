namespace TMPS_lab3.Observer
{
    public static class ObserverExample
    {
        public static void StartExample()
        {
            var store = new Store();

            var p1 = new Product() { Name = "Shoes", Description = "Black", Price = 899 };
            var p2 = new Product() { Name = "T-Shirt", Description = "White oversized", Price = 249.99 };
            var p3 = new Product() { Name = "Gloves", Description = "Black", Price = 99 };
            var p4 = new Product() { Name = "Glasses", Description = "For sun", Price = 175.50 };

            store.Subscribe(new MailMessage());

            var order1 = new Order() { Products = new List<Product>() { p1, p2, p3, p4 } };
            store.AddNewArrivedOrder(order1);

            Console.WriteLine($"\n{new string('*', 50)}\n");

            ISubscriber smsMsg = new SmsMessage();
            store.Subscribe(smsMsg);

            var order2 = new Order() { Products = new List<Product> { p4, p2 } };
            store.AddNewArrivedOrder(order2);
        }
    }
}