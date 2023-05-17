namespace TMPS_lab3.TemplateMethod
{
    public class ElectronicProductManager : ProductManager
    {
        public override Product CreateProduct()
        {
            var product = new Product();

            Console.WriteLine("Crearea unui produs electronic");
            Console.WriteLine("Numele: ");
            product.Name = Console.ReadLine() ?? "";
            Console.WriteLine("Pretul: ");
            double.TryParse(Console.ReadLine(), out double price);
            product.Price = price;
            product.WarrantyInMonths = 24;

            return product;
        }
    }
}