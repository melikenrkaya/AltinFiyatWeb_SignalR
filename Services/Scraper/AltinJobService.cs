using AltınFiyatWeb__SignalR_.Hubs;
using Microsoft.AspNetCore.SignalR;

namespace AltınFiyatWeb__SignalR_.Services.Scraper
{
    public class AltinJobService
    {
        private readonly AltinPriceScraper _scraper;
        private readonly IHubContext<PriceHub> _hub;

        private decimal _lastAlis = 0;
        private decimal _lastSatis = 0;

        public AltinJobService(AltinPriceScraper scraper, IHubContext<PriceHub> hub)
        {
            _scraper = scraper;
            _hub = hub;
        }

        public async Task CheckAndNotifyAsync()
        {
            var (alis, satis) = await _scraper.GetGramAltinAsync();

            if (alis != _lastAlis || satis != _lastSatis)
            {
                _lastAlis = alis;
                _lastSatis = satis;

                await _hub.Clients.All.SendAsync("ReceivePrice", new { Alis = alis, Satis = satis });
                Console.WriteLine($"[GÜNCEL] Alış: {alis} | Satış: {satis}");
            }
        }
    }
}


