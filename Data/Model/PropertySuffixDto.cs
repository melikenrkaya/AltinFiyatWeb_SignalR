namespace AltınFiyatWeb__SignalR_.Data.Model
{
    public class PropertySuffixDto
    {
        public int Id { get; set; }
        public string? PropertySuffixName { get; set; }
        public int PropertySuffix { get; set; }
        public DateTime CreatedTime { get; set; } = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.CreateCustomTimeZone("UTC+3", TimeSpan.FromHours(3), "UTC+3", "UTC+3"));
        public DateTime UpdatedTime { get; set; }
    }
}
