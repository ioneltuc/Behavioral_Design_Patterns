namespace TMPS_lab3.State
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Discount { get; set; }
        private ProductState _state;

        public Product(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
            Discount = 0;
            _state = new StandardState(this);
        }

        public void ChangeState(ProductState state)
        {
            _state = state;
        }

        public void RemoveProductDiscount()
        {
            _state.RemoveProductDiscount();
        }

        public void PutProductOnSale()
        {
            _state.PutProductOnSale();
        }

        public void PutProductOnClearanceSale()
        {
            _state.PutProductOnClearanceSale();
        }
    }
}