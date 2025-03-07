using VillanyszamlaKoltsegekBackend.Model;

namespace VillanyszamlaKoltsegekBackend.Data
{
    public class YearRepository
    {
        List<Year> years;

        public YearRepository()
        {
            this.years = new List<Year>();
        }

        public void Add(Year year)
        {
            years.Add(year);
        }

        public void RemoveAll()
        {
            years.Clear();
        }

        public IEnumerable<Year> GetAll()
        {
            return years;
        }
    }
}
