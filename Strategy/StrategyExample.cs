using TMPS_lab3.Observer;

namespace TMPS_lab3.Strategy
{
    public static class StrategyExample
    {
        public static void StartExample()
        {
            var store = new Store();

            var p1 = new Product() { Name = "Shoes", Description = "Black", Price = 899 };
            var p2 = new Product() { Name = "T-Shirt", Description = "White oversized", Price = 249.99 };
            var p3 = new Product() { Name = "Gloves", Description = "Black", Price = 99 };
            var p4 = new Product() { Name = "Glasses", Description = "For sun", Price = 175.50 };
            var products = new List<Product>() { p1, p2, p3, p4 };

            store.SetSortStrategy(new SortByPrice());

            store.Sort(ref products, SortType.Descending);

            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name}\n" +
                    $"Description: {product.Description}\n" +
                    $"Price: {product.Price}\n\n");
            }
        }
    }
}