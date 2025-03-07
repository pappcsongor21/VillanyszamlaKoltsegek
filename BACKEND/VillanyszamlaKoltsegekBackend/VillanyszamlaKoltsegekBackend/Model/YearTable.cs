namespace VillanyszamlaKoltsegekBackend.Model
{
    public class YearTable
    {
        public YearTable(Year[] years, int unitPrice)
        {
            Years = years;
            UnitPrice = unitPrice;
        }

        public Year[] Years { get; set; }
        public int UnitPrice { get; set; }
        
    }
}
