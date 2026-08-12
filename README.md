# 🚗 Araç Kayıt ve Takip Sistemi

**Araç Kayıt ve Takip Sistemi**, araçların, firmaların ve ilgili personel bilgilerinin yönetilmesi amacıyla geliştirilmiş Windows masaüstü uygulamasıdır.

Proje **C# / Windows Forms** ile geliştirilmiş olup kullanıcı arayüzünde **MetroFramework** kullanır. Veri erişimi `System.Data.SqlClient` üzerinden **Microsoft SQL Server** veritabanına yapılmaktadır. Proje .NET Framework 4.0 hedeflemektedir. fileciteturn93file0turn95file0

## ✨ Özellikler

- 🚗 Araç kayıt işlemleri
- ✏️ Araç bilgilerini güncelleme
- 🗑️ Araç kayıtlarını silme
- 🔎 Araç kayıtlarını kontrol etme ve takip etme
- 🏢 Firma kayıt işlemleri
- 👥 Personel bilgilerini yönetme
- 🔐 Kullanıcı giriş ekranı
- 📊 Raporlama ekranları
- 🖥️ MetroFramework tabanlı arayüz
- 🗄️ Microsoft SQL Server entegrasyonu

Proje kaynaklarında araç ve firma yönetimi, personel bilgileri, giriş, kayıt, güncelleme, silme ve raporlama ekranları ayrı Windows Forms sınıfları halinde organize edilmiştir. fileciteturn93file0

## 🛠️ Kullanılan Teknolojiler

- **C#**
- **Windows Forms**
- **.NET Framework 4.0**
- **Microsoft SQL Server**
- **System.Data.SqlClient**
- **MetroFramework**
- **Visual Studio**

## 📂 Proje Yapısı

```text
Ara-_Takip-Sistemi/
│
├── Araç Kayıt ve Takip Sistemi.sln
│
└── Araç Kayıt ve Takip Sistemi/
    ├── Program.cs
    ├── baglanti.cs
    ├── degerler.cs
    ├── kayit_islemleri.cs
    ├── arac_cks.cs
    ├── arac_save.cs
    ├── arac_update.cs
    ├── arac_delete.cs
    ├── arc_grs.cs
    ├── firma_ekle.cs
    ├── firma_delete.cs
    ├── firma_komuta_merekzi.cs
    ├── prsnl_blglr.cs
    ├── k_giris.cs
    ├── Komutamerkezi.cs
    ├── frm_update.cs
    ├── Arac_firma_kontrol Merkezi.cs
    ├── Properties/
    └── resim ve iconlar/
```

Proje dosyasında araç, firma, personel, giriş, komuta merkezi ve raporlama ile ilişkili çok sayıda Windows Forms ekranı tanımlanmıştır. fileciteturn93file0

## 🔐 Giriş Sistemi

Uygulama başlatıldığında `Program.cs`, Windows Forms uygulamasını başlatır ve ilk ekran olarak `k_giris` formunu açar. fileciteturn94file0

```csharp
Application.Run(new k_giris());
```

## 🗄️ Veritabanı

Uygulama Microsoft SQL Server kullanır. Bağlantı sınıfında `arac_takip_otomasyonu` adlı veritabanına bağlanacak şekilde yapılandırılmıştır.

Temel bağlantı yapısı:

```text
Server=<SQL_SERVER>;
Integrated Security=true;
Database=arac_takip_otomasyonu;
Pooling=true;
```

Sunucu adı `C:\ayar.txt` dosyasından okunacak şekilde tasarlanmıştır. Bu nedenle uygulamanın çalışacağı bilgisayarda uygun yapılandırma dosyasının bulunması gerekir. fileciteturn95file0

> ⚠️ **Güvenlik:** Gerçek sistemlerde veritabanı bağlantı bilgilerini kaynak koduna veya sabit bir dosya yoluna gömmek yerine güvenli yapılandırma yöntemi kullanılması önerilir.

## ⚙️ Kurulum

### Gereksinimler

- Windows
- Visual Studio
- .NET Framework 4.0 veya projeyi çalıştırabilecek uyumlu .NET ortamı
- Microsoft SQL Server
- MetroFramework bağımlılığı

### 1. Repoyu klonlayın

```bash
git clone https://github.com/ebubekirbastama/Ara-_Takip-Sistemi.git
```

### 2. Solution dosyasını açın

Visual Studio ile:

```text
Araç Kayıt ve Takip Sistemi.sln
```

dosyasını açın.

### 3. SQL Server'ı hazırlayın

`arac_takip_otomasyonu` adlı veritabanını oluşturun ve projenin kullandığı tabloları kendi SQL Server ortamınıza göre hazırlayın.

### 4. Sunucu ayarını yapın

Uygulama sunucu adını:

```text
C:\ayar.txt
```

dosyasından okumaktadır. Dosyanın ilk satırına SQL Server sunucu adını yazın.

### 5. Derleyin ve çalıştırın

Visual Studio'da çözümü derledikten sonra uygulamayı çalıştırın. Program giriş ekranını açacaktır.

## 🧭 Temel Uygulama Akışı

```text
┌──────────────────┐
│    Giriş Ekranı  │
└────────┬─────────┘
         │
         ▼
┌──────────────────┐
│  Komuta Merkezi  │
└────────┬─────────┘
         │
    ┌────┼────┐
    ▼    ▼    ▼
  Araç  Firma Personel
    │    │    │
    └────┼────┘
         ▼
      Raporlama
```

## 📌 Proje Durumu

Proje, eski bir **.NET Framework 4.0 / Visual Studio** kod tabanı olarak hazırlanmıştır. Modern geliştirme ortamlarında çalıştırmadan önce MetroFramework bağımlılığı ve kullanılan .NET Framework sürümü kontrol edilmelidir.

Gelecekte yapılabilecek geliştirmeler:

- Modern .NET sürümüne geçiş
- Entity Framework veya güncel veri erişim katmanı kullanımı
- Yapılandırmanın `app.config` / güvenli yapılandırmaya taşınması
- SQL sorgularının ve kullanıcı yetkilendirmesinin güvenlik açısından gözden geçirilmesi
- Birim ve entegrasyon testlerinin eklenmesi
- Daha modern ve responsive kullanıcı arayüzü

## 🤝 Katkıda Bulunma

1. Repoyu fork edin.
2. Yeni bir branch oluşturun.
3. Değişikliklerinizi yapın.
4. Test edin.
5. Pull Request gönderin.

## 📄 Lisans

Bu depoda ayrı bir lisans dosyası bulunuyorsa ilgili lisans koşulları geçerlidir. Aksi durumda projeyi yeniden dağıtmadan önce proje sahibiyle kullanım koşullarını netleştirmeniz önerilir.

## 👨‍💻 Geliştirici

**Ebubekir Bastama**

GitHub: https://github.com/ebubekirbastama
