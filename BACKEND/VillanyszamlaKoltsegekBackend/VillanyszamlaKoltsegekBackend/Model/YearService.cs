namespace VillanyszamlaKoltsegekBackend.Model
{
    public class YearService
    {
        public Year[] Years { get; set; }
        public int PricePerUnit { get; set; }

        public YearService(Year[] years, int pricePerUnit)
        {
            Years = years;
            PricePerUnit = pricePerUnit;
        }
    }
}
