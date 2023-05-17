namespace TMPS_lab3.TemplateMethod
{
    public static class TemplateMethodExample
    {
        public static void StartExample()
        {
            ProductManager manager = new ElectronicProductManager();
            Product keyboard = manager.CreateProduct();
            Console.WriteLine(manager.DisplayProduct(keyboard));

            manager = new FurnitureProductManager();
            Product sofa = manager.CreateProduct();
            Console.WriteLine(manager.DisplayProduct(sofa));
        }
    }
}