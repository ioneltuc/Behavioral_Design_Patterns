namespace TMPS_lab3.Observer
{
    public interface ISubscriber
    {
        string Update(Order order);
    }
}