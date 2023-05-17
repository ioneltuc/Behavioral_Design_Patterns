namespace TMPS_lab3.Memento
{
    public interface IMemento
    {
        string GetName();

        string GetDescription();

        double GetPrice();

        DateTime GetDateCreated();

        DateTime GetDateLastModified();
    }
}