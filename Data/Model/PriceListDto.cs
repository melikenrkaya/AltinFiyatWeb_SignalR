namespace AltınFiyatWeb__SignalR_.Data.Model
{
    public class PriceListDto
    {
        public int Id { get; set; }
        public int PropertySuffixId { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}
