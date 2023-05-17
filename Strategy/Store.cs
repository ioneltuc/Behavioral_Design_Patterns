using TMPS_lab3.Observer;

namespace TMPS_lab3.Strategy
{
    public class Store
    {
        private ISortStrategy _sortStrategy;

        public void SetSortStrategy(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void Sort(ref List<Product> products, SortType sortType = SortType.Ascending)
        {
            _sortStrategy.Sort(ref products, sortType);
        }
    }
}