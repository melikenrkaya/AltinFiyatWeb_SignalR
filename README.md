# 🟡 Altın Fiyat Web (SignalR)

Bu proje, canlı altın fiyatlarını web scraping ile `canlidoviz.com` üzerinden çekip, SignalR kullanarak frontend'e gerçek zamanlı olarak ileten bir ASP.NET Core Web uygulamasıdır.

## 🔧 Teknolojiler

- ASP.NET Core Web API
- SignalR
- HtmlAgilityPack (Scraper için)
- Entity Framework Core
- C#
- JavaScript (clienthtmlpage.html)

## 📁 Katmanlar ve Klasörler

```
📦 AltinFiyatWeb_SignalR-main
 ┣ 📂Hubs                    → SignalR Hub (PriceHub.cs)
 ┣ 📂Services/Scraper        → Scraper & Job servisleri
 ┣ 📂wwwroot                 → Frontend HTML demo
 ┣ appsettings.json          → Config dosyası
 ┣ Program.cs                → Uygulama giriş noktası
 ┗ AltınFiyatWeb SignalR.sln → Çözüm dosyası
```
Projenin konsol ve çıktı görüntüsü. Basic bir arayüz tercih ettim. Amacım projeyi çalıştırmaktı.
**🖼️ Projenin konsol ve çıktı görüntüsü**  
**🧪 Basic bir arayüz tercih ettim. Amacım projeyi çalıştırmaktı.**
### 🖥️ Proje Konsol ve Çıktı Görüntüsü

**Basic bir arayüz tercih ettim. Amacım projeyi çalıştırmaktı.**


<img width="987" height="1060" alt="websignalr" src="https://github.com/user-attachments/assets/6bf566fa-b690-4e4b-b20f-7727d45c25a9" />

<img width="721" height="662" alt="image" src="https://github.com/user-attachments/assets/ce6801d1-3ecd-4af3-8c8e-c0842240d4fc" />

## ⚙️ Kurulum

1. Projeyi klonlayın:
   ```bash
   git clone https://github.com/kullanici/AltinFiyatWeb_SignalR.git
   ```

2. NuGet paketlerini yükleyin:
   - `HtmlAgilityPack`
   - `Microsoft.AspNetCore.SignalR`
   - `Microsoft.EntityFrameworkCore.SqlServer`
3. Uygulamayı çalıştırın:
   ```bash
   dotnet run
   ```

## 🔁 Gerçek Zamanlı Fiyat Yayını

`AltinJobService` sınıfı, belirli aralıklarla scraping işlemi yapar. Eğer `alış` veya `satış` fiyatı bir önceki fiyattan farklıysa, `PriceHub` üzerinden SignalR yayını yapılır.

## 🧪 Demo

`wwwroot/clienthtmlpage.html` dosyasını açarak fiyatların gerçek zamanlı nasıl aktığını izleyebilirsiniz.

## 📌 Notlar

- SignalR ile sadece değişen fiyatlar yayınlanır.
- NullReferenceException hatalarına karşı `_lastAlis` ve `_lastSatis` gibi değişkenler dikkatle kontrol edilmelidir.
- Fiyat bilgileri `AltinPriceScraper.cs` dosyasında `HtmlAgilityPack` ile çekilmektedir.

## 👩‍💻 Geliştiren

Melikenur Kaya  
[LinkedIn](https://linkedin.com/in/melikenur-kaya) • [GitHub](https://github.com/melikenrkaya)


