using TMPS_lab3.Observer;

namespace TMPS_lab3.Strategy
{
    public interface ISortStrategy
    {
        void Sort(ref List<Product> products, SortType sortType = SortType.Ascending);
    }
}