namespace TMPS_lab3.Observer
{
    public class Store
    {
        private List<ISubscriber> _subscribers;
        private List<Order> _arrivedOrders;

        public Store()
        {
            _subscribers = new List<ISubscriber>();
            _arrivedOrders = new List<Order>();
        }

        public void Subscribe(ISubscriber subscriber)
        {
            if (!_subscribers.Contains(subscriber))
            {
                _subscribers.Add(subscriber);
            }
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            if (_subscribers.Contains(subscriber))
            {
                _subscribers.Remove(subscriber);
            }
        }

        public void AddNewArrivedOrder(Order order)
        {
            _arrivedOrders.Add(order);

            foreach (ISubscriber subscriber in _subscribers)
            {
                subscriber.Update(order);
            }
        }
    }
}