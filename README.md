# Otel Rezervasyon Projesi

## Proje Hakkında

Otel Rezervasyon Projesi, kullanıcıların otel odalarını kolayca arayabileceği, görüntüleyebileceği ve rezervasyon yapabileceği modern ve kullanıcı dostu bir web uygulamasıdır. Proje, ASP.NET Core MVC kullanılarak geliştirilmiş olup, veritabanı işlemleri için Entity Framework Core kullanılmaktadır.

## Özellikler

- **Kullanıcı Kimlik Doğrulama**: Güvenli kullanıcı kaydı ve giriş işlemleri.
- **Otel Arama**: Şehir ve ülkeye göre otel arama özelliği.
- **Oda Detayları**: Odaların detaylı bilgilerini görüntüleme.
- **Rezervasyon Yönetimi**: Otel odası rezervasyonu yapma ve mevcut rezervasyonları yönetme.
- **Yönetici Paneli**: Otelleri, odaları ve rezervasyonları yönetme.

## Kullanılan Teknolojiler

- **Backend**: ASP.NET Core MVC
- **ORM**: Entity Framework Core
- **Veritabanı**: SQL Server
- **Frontend**: Bootstrap
- **JavaScript**: Dinamik fonksiyonellikler için

## Kurulum ve Yükleme

### Gereksinimler

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Git](https://git-scm.com/)

### Adımlar

1. **Depoyu Klonlayın**:
    ```bash
    git clone https://github.com/firatgg/HotelReservationProject-1.git
    cd HotelReservationProject-1
    ```

2. **Bağlantı Dizesini Güncelleyin**:
   `appsettings.json` dosyasında bulunan veritabanı bağlantı dizesini kendi SQL Server instance'ınıza göre güncelleyin.

3. **Migrationları Uygulama ve Veritabanını Güncelleme**:
    ```bash
    dotnet ef database update
    ```

4. **Uygulamayı Çalıştırın**:
    ```bash
    dotnet run
    ```

5. **Uygulamaya Erişim**:
   Tarayıcınızı açın ve `https://localhost:5001` adresine gidin.

## Kullanım Kılavuzu

### Kullanıcı İşlemleri

1. **Kayıt ve Giriş**:
   - Yeni bir kullanıcı hesabı oluşturun.
   - Oluşturduğunuz bilgilerle giriş yapın.

2. **Otel Arama**:
   - Şehir ve ülkeye göre otel araması yapın.

3. **Oda Detayları**:
   - Otel detaylarını görüntüleyin ve odalar hakkında bilgi edinin.

4. **Rezervasyon Yapma**:
   - Bir oda seçin ve rezervasyon işlemlerini tamamlayın.

### Yönetici İşlemleri

1. **Yönetici Paneli**:
   - Yönetici girişi yaparak otelleri, odaları ve rezervasyonları yönetin.

## Proje Yapısı

- **Controllers**: Uygulamanın kontrolörlerini içerir.
- **Models**: Veri modellerini içerir.
- **Views**: Razor görünümlerini içerir.
- **wwwroot**: CSS, JavaScript ve görseller gibi statik dosyaları içerir.
- **Migrations**: Entity Framework Core migration dosyalarını içerir.

## Katkıda Bulunma

Projeye katkıda bulunmak isterseniz, lütfen aşağıdaki adımları takip edin:

1. Depoyu forklayın.
2. Yeni bir dal oluşturun (`git checkout -b ozellik-adi`).
3. Değişikliklerinizi gerçekleştirin ve kaydedin (`git commit -m 'Özellik ekle: özelliğin kısa açıklaması'`).
4. Değişikliklerinizi dala gönderin (`git push origin ozellik-adi`).
5. Bir Pull Request oluşturun.

## Lisans

Bu proje MIT Lisansı ile lisanslanmıştır. Daha fazla bilgi için [LICENSE](LICENSE) dosyasına göz atabilirsiniz.

## İletişim

Herhangi bir soru veya öneriniz için lütfen proje yöneticisi ile iletişime geçin:

- **Fırat Gültekin** - [euphratesgultekin@gmail.com](mailto:euphratesgultekin@gmail.com)
- **Emirhan Yıldız** - [kucuk.hotonoglu@gmail.com](mailto:kucuk.hotonoglu@gmail.com)
- **Hüseyin Can Aksoy** - [huseyincanaksoy1@outlook.com](mailto:huseyincanaksoy1@outlook.com)
 

---

Otel Rezervasyon Projesi'ni kullandığınız için teşekkür ederiz!
