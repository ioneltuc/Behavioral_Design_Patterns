namespace TMPS_lab3.Memento
{
    public class Caretaker
    {
        private List<IMemento> _mementos;
        private Product _product;

        public Caretaker(Product product)
        {
            _mementos = new List<IMemento>();
            _product = product;
        }

        public void Save()
        {
            _mementos.Add(_product.Save());
        }

        public void Undo()
        {
            if (_mementos.Count == 0)
            {
                Console.WriteLine("No saves available.");
                return;
            }

            if (_mementos.Count == 1)
            {
                _product.UpdateState(_mementos.First());
                return;
            }

            var lastProductMemento = _mementos.Last();
            _mementos.Remove(lastProductMemento);
            _product.UpdateState(_mementos.Last());
        }

        public void ShowHistory()
        {
            Console.WriteLine("History:");

            foreach (ProductMemento productMemento in _mementos)
            {
                Console.WriteLine($"Name: {productMemento.GetName()}\n" +
                    $"Description: {productMemento.GetDescription()}\n" +
                    $"Price: {productMemento.GetPrice()}\n" +
                    $"Created: {productMemento.GetDateCreated()}\n" +
                    $"Modified: {productMemento.GetDateLastModified()}\n");
            }
        }
    }
}