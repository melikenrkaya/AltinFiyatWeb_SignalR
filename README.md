Tamam, işte senin **WordToPdf & Video Downloader** projen için, senin istediğin gibi **düz, temiz ve Altın Fiyat Web örneği formatında** README:

---

# 📄 Word to PDF & 🎥 Video Downloader API

Bu proje, **Word belgelerini PDF formatına dönüştüren** ve **YouTube/desteklenen platformlardan video indiren** bir **ASP.NET Core Web API** uygulamasıdır.
Videolar `yt-dlp` ile indirilir, **FFmpeg** ile H.264 + AAC formatında encode edilerek her oynatıcıda sorunsuz çalışır.

---

## 🔧 Teknolojiler

* ASP.NET Core Web API
* Swagger UI
* Aspose.Words (Word → PDF dönüşümü)
* yt-dlp (Video indirme aracı)
* FFmpeg (Video/ses encode)
* C#

---

## 📁 Katmanlar ve Klasörler

```
📦 WordToPdf-And-YoutubeDownloadVideo
 ┣ 📂Controllers        → API Controller dosyaları
 ┣ 📂Downloads          → İndirilen videolar
 ┣ 📂Properties         → Proje ayarları
 ┣ appsettings.json     → Config dosyası
 ┣ Program.cs           → Uygulama giriş noktası
 ┗ WordToPdf.sln        → Çözüm dosyası
```

---

## 🖥️ Proje Konsol ve Çıktı Görüntüsü

<img width="987" alt="swagger" src="https://github.com/user-attachments/assets/xxx" />

<img width="721" alt="download" src="https://github.com/user-attachments/assets/yyy" />

---

## ⚙️ Kurulum

1. Projeyi klonlayın:

   ```bash
   git clone https://github.com/KULLANICI_ADI/WordToPdf-And-YoutubeDownloadVideo.git
   ```

2. Gerekli bağımlılıkları yükleyin:

   * Aspose.Words
   * yt-dlp.exe ve ffmpeg.exe dosyalarını proje kök klasörüne ekleyin
   * Properties → Copy to Output Directory → Copy always

3. Uygulamayı çalıştırın:

   ```bash
   dotnet run
   ```

Tarayıcıda: **[http://localhost:5116/index.html](http://localhost:5116/index.html)**

---

## 📌 API Endpoint’leri

### 📄 Word → PDF

```
POST /Convert/WordToPdf
```

Form-Data:

* `file` → Word dosyası (.docx, .doc)

Dönüş: PDF dosyası yolu

---

### 🎥 Video İndir

```
POST /Convert/DownloadVideo
```

Body (JSON):

```json
{
  "url": "https://www.youtube.com/watch?v=VIDEO_ID"
}
```

Dönüş (JSON):

```json
{
  "message": "Video başarıyla indirildi ve uyumlu MP4 formatına dönüştürüldü",
  "filePath": "C:\\path\\to\\Downloads\\video.mp4",
  "sizeMB": 123.45
}
```

---

## 📌 Notlar

* Büyük dosyaları (`*.mp4`, `*.exe`) `.gitignore` ile hariç tutun.
* İndirme hızı internet bağlantınıza ve seçilen kaliteye göre değişebilir.
* FFmpeg ve yt-dlp olmadan video indirme çalışmaz.

---

## 👩‍💻 Geliştiren

Melikenur Kaya
[LinkedIn](https://linkedin.com/in/melikenur-kaya) • [GitHub](https://github.com/melikenrkaya)

---

Eğer istersen buradaki `<img>` linklerini **senin yüklediğin gerçek ekran görüntüleriyle** doldurabilirim ki GitHub’da birebir düzgün gözüksün.
Onu da yapmamı ister misin?
