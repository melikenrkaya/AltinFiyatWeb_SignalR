using System.ComponentModel.DataAnnotations.Schema;

namespace AltınFiyatWeb__SignalR_.Data.Entity
{
    public class PriceList
    {
        public int Id { get; set; }
        public int PropertySuffixId { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal BuyPrice { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal SellPrice { get; set; }
        public DateTime CreatedTime { get; set; } = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.CreateCustomTimeZone("UTC+3", TimeSpan.FromHours(3), "UTC+3", "UTC+3"));
        public DateTime UpdatedTime { get; set; }

    }
}
