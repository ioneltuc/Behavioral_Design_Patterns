namespace TMPS_lab3.Memento
{
    public class ProductMemento : IMemento
    {
        private string _name;
        private string _description;
        private double _price;
        private DateTime _created;
        private DateTime _lastModified;

        public ProductMemento(string name, string description, double price, DateTime created)
        {
            _name = name;
            _description = description;
            _price = price;
            _created = created;
            _lastModified = DateTime.Now;
        }

        public DateTime GetDateCreated()
        {
            return _created;
        }

        public string GetDescription()
        {
            return _description;
        }

        public string GetName()
        {
            return _name;
        }

        public double GetPrice()
        {
            return _price;
        }

        public DateTime GetDateLastModified()
        {
            return _lastModified;
        }
    }
}