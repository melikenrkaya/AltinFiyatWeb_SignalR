using AltınFiyatWeb__SignalR_.Data.Context;
using AltınFiyatWeb__SignalR_.Data.Entity;
using AltınFiyatWeb__SignalR_.Hubs;
using Azure;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace AltınFiyatWeb__SignalR_.Services.Scraper
{
    public class AltinPricePublisher : BackgroundService
        {
            private readonly IHubContext<PriceHub> _hub;
            private readonly AltinPriceScraper _scraper;

            private decimal _lastAlis;
            private decimal _lastSatis;

            public AltinPricePublisher(IHubContext<PriceHub> hub, AltinPriceScraper scraper)
            {
                _hub = hub;
                _scraper = scraper;
            }

            protected override async Task ExecuteAsync(CancellationToken stoppingToken)
            {
                while (!stoppingToken.IsCancellationRequested)
                {
                    var (alis, satis) = await _scraper.GetGramAltinAsync();

                    if (alis != _lastAlis || satis != _lastSatis)
                    {
                        _lastAlis = alis;
                        _lastSatis = satis;

                        await _hub.Clients.All.SendAsync("ReceivePrice", new { Alis = alis, Satis = satis });
                    }

                    await Task.Delay(TimeSpan.FromSeconds(3), stoppingToken);
                }
            }
        }
    }

