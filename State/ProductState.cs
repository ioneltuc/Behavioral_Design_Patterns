namespace TMPS_lab3.State
{
    public abstract class ProductState
    {
        protected Product Product;

        public ProductState(Product product)
        {
            Product = product;
        }

        public abstract void RemoveProductDiscount();

        public abstract void PutProductOnSale();

        public abstract void PutProductOnClearanceSale();
    }
}