namespace VeriAnalizKonsol
{
    public class SaleRecord
    {
        public string CustomerName { get; set; } = string.Empty;
        public string Product { get; set; } = string.Empty;
        public DateTime SaleDate { get; set; }
        public decimal Amount { get; set; }
    }
}
