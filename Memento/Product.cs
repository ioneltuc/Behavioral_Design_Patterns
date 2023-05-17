namespace TMPS_lab3.Memento
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        private DateTime _created;

        public Product(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
            _created = DateTime.Now;
        }

        public IMemento Save()
        {
            return new ProductMemento(Name, Description, Price, _created);
        }

        public void UpdateState(IMemento memento)
        {
            Name = memento.GetName();
            Description = memento.GetDescription();
            Price = memento.GetPrice();

            Console.WriteLine($"Current product state:\n" +
                $"\tName: {memento.GetName()}\n" +
                $"\tDescription: {memento.GetDescription()}\n" +
                $"\tPrice: {memento.GetPrice()}\n" +
                $"\tCreated: {memento.GetDateCreated()}\n" +
                $"\tModified: {memento.GetDateLastModified()}\n\n");
        }
    }
}