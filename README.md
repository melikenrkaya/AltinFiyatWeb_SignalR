# 🟡 Altın Fiyat Web (SignalR)

Bu proje, canlı altın fiyatlarını web scraping ile `canlidoviz.com` üzerinden çekip, SignalR kullanarak frontend'e gerçek zamanlı olarak ileten bir ASP.NET Core Web uygulamasıdır.

## 🔧 Teknolojiler

- ASP.NET Core Web API
- SignalR
- HtmlAgilityPack (Scraper için)
- Entity Framework Core
- SQL Server
- C#
- JSON (DTO & Config)
- JavaScript (clienthtmlpage.html)

## 📁 Katmanlar ve Klasörler

📦 AltinFiyatWeb_SignalR-main
┣ 📂Controller → Fiyat API kontrolü (PriceListController.cs)
┣ 📂Hubs → SignalR Hub (PriceHub.cs)
┣ 📂Services/Scraper → Scraper & Job servisleri
┣ 📂Data
┃ ┣ 📂Context → DbContext sınıfı
┃ ┣ 📂Entity → Entity modelleri (PriceList.cs vs.)
┃ ┗ 📂Model → DTO sınıfları
┣ 📂Common → Extension sınıflar
┣ 📂wwwroot → Frontend HTML demo
┣ appsettings.json → Config dosyası
┣ Program.cs → Uygulama giriş noktası
┗ AltınFiyatWeb SignalR.sln → Çözüm dosyası


## ⚙️ Kurulum

1. Projeyi klonlayın:
   ```bash
   git clone https://github.com/kullanici/AltinFiyatWeb_SignalR.git
2.NuGet paketlerini yükleyin:

HtmlAgilityPack
Microsoft.AspNetCore.SignalR
Microsoft.EntityFrameworkCore.SqlServer

3.Veritabanı bağlantısını appsettings.json dosyasından yapın:

"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=AltinFiyatDB;Trusted_Connection=True;"
}
4.Migration ve veritabanı oluşturun:

dotnet ef migrations add InitialCreate
dotnet ef database update

5.Uygulamayı çalıştırın:

dotnet run

🔁 Gerçek Zamanlı Fiyat Yayını
AltinJobService sınıfı, belirli aralıklarla scraping işlemi yapar. Eğer alış veya satış fiyatı bir önceki fiyattan farklıysa, PriceHub üzerinden SignalR yayını yapılır.

🧪 Demo
wwwroot/clienthtmlpage.html dosyasını açarak fiyatların gerçek zamanlı nasıl aktığını izleyebilirsiniz.
📌 Notlar
SignalR ile sadece değişen fiyatlar yayınlanır.

NullReferenceException hatalarına karşı _lastAlis ve _lastSatis gibi değişkenler dikkatle kontrol edilmelidir.

Fiyat bilgileri AltinPriceScraper.cs dosyasında HtmlAgilityPack ile çekilmektedir.
## 👩‍💻 Geliştiren

Melikenur Kaya  
[LinkedIn](https://linkedin.com/in/melikenur-kaya) • [GitHub](https://github.com/melikenrkaya)

# 🟡 Altın Fiyat Web (SignalR)

Bu proje, canlı altın fiyatlarını web scraping ile `canlidoviz.com` üzerinden çekip, SignalR kullanarak frontend'e gerçek zamanlı olarak ileten bir ASP.NET Core Web uygulamasıdır.

## 🔧 Teknolojiler

- ASP.NET Core Web API
- SignalR
- HtmlAgilityPack (Scraper için)
- Entity Framework Core
- SQL Server
- C#
- JSON (DTO & Config)
- JavaScript (clienthtmlpage.html)

## 📁 Katmanlar ve Klasörler

```
📦 AltinFiyatWeb_SignalR-main
 ┣ 📂Controller              → Fiyat API kontrolü (PriceListController.cs)
 ┣ 📂Hubs                    → SignalR Hub (PriceHub.cs)
 ┣ 📂Services/Scraper        → Scraper & Job servisleri
 ┣ 📂Data
 ┃ ┣ 📂Context              → DbContext sınıfı
 ┃ ┣ 📂Entity               → Entity modelleri (PriceList.cs vs.)
 ┃ ┗ 📂Model                → DTO sınıfları
 ┣ 📂Common                  → Extension sınıflar
 ┣ 📂wwwroot                 → Frontend HTML demo
 ┣ appsettings.json          → Config dosyası
 ┣ Program.cs                → Uygulama giriş noktası
 ┗ AltınFiyatWeb SignalR.sln → Çözüm dosyası
```

## ⚙️ Kurulum

1. Projeyi klonlayın:
   ```bash
   git clone https://github.com/kullanici/AltinFiyatWeb_SignalR.git
   ```

2. NuGet paketlerini yükleyin:
   - `HtmlAgilityPack`
   - `Microsoft.AspNetCore.SignalR`
   - `Microsoft.EntityFrameworkCore.SqlServer`

3. Veritabanı bağlantısını `appsettings.json` dosyasından yapın:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=.;Database=AltinFiyatDB;Trusted_Connection=True;"
   }
   ```

4. Migration ve veritabanı oluşturun:
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

5. Uygulamayı çalıştırın:
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

