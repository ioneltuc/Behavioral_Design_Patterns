using TMPS_lab3.Observer;

namespace TMPS_lab3.Strategy
{
    public class SortByName : ISortStrategy
    {
        public void Sort(ref List<Product> products, SortType sortType = SortType.Ascending)
        {
            if (sortType == SortType.Descending)
            {
                products = products.OrderByDescending(p => p.Name).ToList();
                return;
            }

            products = products.OrderBy(p => p.Name).ToList();
        }
    }
}