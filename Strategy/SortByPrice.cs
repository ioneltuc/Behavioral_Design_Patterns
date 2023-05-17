using TMPS_lab3.Observer;

namespace TMPS_lab3.Strategy
{
    public class SortByPrice : ISortStrategy
    {
        public void Sort(ref List<Product> products, SortType sortType = SortType.Ascending)
        {
            if (sortType == SortType.Descending)
            {
                products = products.OrderByDescending(p => p.Price).ToList();
                return;
            }

            products = products.OrderBy(p => p.Price).ToList();
        }
    }
}