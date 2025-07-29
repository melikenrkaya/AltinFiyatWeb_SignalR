using HtmlAgilityPack;
using System.Globalization;
using System.Text.Json;

namespace AltınFiyatWeb__SignalR_.Services.Scraper
{
    public class AltinPriceScraper
    {
        private readonly HttpClient _httpClient;
        public AltinPriceScraper()
        {
            _httpClient = new HttpClient();
        }
        public async Task<(decimal Alis, decimal Satis)> GetGramAltinAsync()
        {
            var response = await _httpClient.GetStringAsync("https://canlidoviz.com/altin-fiyatlari/gram-altin");
            var doc = new HtmlDocument();
            doc.LoadHtml(response);

            var alisNode = doc.DocumentNode.SelectSingleNode("/html/body/div[3]/div/div[3]/div[1]/div[1]/div/div[1]/div[2]/div[1]/span[2]");
            var satisNode = doc.DocumentNode.SelectSingleNode("/html/body/div[3]/div/div[3]/div[1]/div[1]/div/div[1]/div[2]/div[2]/span[2]");

            var alisText = ParsePriceText(alisNode?.InnerText);
            var satisText = ParsePriceText(satisNode?.InnerText);

            if (alisText == null || satisText == null)
                throw new Exception("Altın fiyatları parse edilemedi. Selector'lar değişmiş olabilir.");

            return ((decimal)alisText, (decimal)satisText);
        }



        private decimal? ParsePriceText(string raw)
        {
            if (string.IsNullOrWhiteSpace(raw))
                return null;

            raw = raw.Trim()
                     .Replace("TL", "")
                     .Replace("₺", "")
                     .Replace("USD", "")
                     .Replace("$", "")
                     .Replace("€", "")
                     .Replace("£", "")
                     .Replace(" ", "");

            if (raw.Contains(".") && raw.Contains(","))
            {
                raw = raw.Replace(".", "").Replace(",", ".");
            }
            else if (raw.Contains(",") && !raw.Contains("."))
            {
                raw = raw.Replace(",", ".");
            }

            if (decimal.TryParse(raw, NumberStyles.Any, CultureInfo.InvariantCulture, out var result))
                return result;

            return null;
        }


    }
}
