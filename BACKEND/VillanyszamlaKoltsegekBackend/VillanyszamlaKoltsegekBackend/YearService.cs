using VillanyszamlaKoltsegekBackend.Model;

namespace VillanyszamlaKoltsegekBackend
{
    public class YearService
    {
        public Year[] Years { get; set; }
        public int PricePerUnit { get; set; }

        public YearService(Year[] years, int pricePerUnit)
        {
            this.Years = years;
            this.PricePerUnit = pricePerUnit;
        }
    }
}
