namespace TMPS_lab3.TemplateMethod
{
    public abstract class ProductManager
    {
        public abstract Product CreateProduct();

        public virtual string DisplayProduct(Product product)
        {
            return $"Product name: {product.Name}\n" +
                $"Product price: {product.Price} lei\n" +
                $"Warranty: {product.WarrantyInMonths} luni";
        }
    }
}