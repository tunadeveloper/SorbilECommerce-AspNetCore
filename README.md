# 🛒 Sorbil E-Ticaret Projesi

Bu proje, **Sorbil Eğitim Kurumu** için eğitim amaçlı geliştirilmiş modern bir e-ticaret web uygulamasıdır. Proje, katmanlı mimari (Layered Architecture) prensiplerine uygun olarak geliştirilmiştir.

## 📋 Proje Hakkında

Bu e-ticaret projesi, öğrencilere modern web geliştirme teknolojilerini öğretmek amacıyla tasarlanmıştır. Proje, gerçek dünya uygulamalarında kullanılan teknolojileri ve mimari yapıları içermektedir.

## 🏗️ Proje Mimarisi

Proje, **4 ana katmandan** oluşmaktadır:

- **📊 EntityLayer**: Veritabanı varlıkları (Entities)
- **💾 DataAccessLayer**: Veri erişim katmanı (Repository Pattern)
- **⚙️ BusinessLayer**: İş mantığı katmanı (Service Layer)
- **🎨 PresentationLayer**: Sunum katmanı (ASP.NET Core MVC)

## 🛠️ Kullanılan Teknolojiler

### Backend Teknolojileri
- **.NET 8.0** - Modern .NET platformu
- **ASP.NET Core MVC** - Web uygulama framework'ü
- **C#** - Programlama dili
- **Entity Framework Core 8** - ORM (Object-Relational Mapping)
- **SQL Server** - Veritabanı
- **FluentValidation.AspNetCore 11** - Model doğrulama

## 🚀 Özellikler

### Kullanıcı Tarafı
- ✅ Ürün listeleme ve detay görüntüleme
- ✅ Kategori bazlı ürün filtreleme
- ✅ Blog sistemi
- ✅ İletişim formu
- ✅ Newsletter aboneliği
- ✅ Responsive tasarım

### Admin Paneli
- ✅ Ürün yönetimi (CRUD işlemleri)
- ✅ Kategori yönetimi
- ✅ Blog yönetimi
- ✅ Kullanıcı yönetimi
- ✅ İletişim mesajları yönetimi
- ✅ Hakkımızda sayfası yönetimi

<img width="1920" height="3812" alt="Image" src="https://github.com/user-attachments/assets/872328c3-1abb-4f6c-a652-782878825891" />
<img width="1920" height="2385" alt="Image" src="https://github.com/user-attachments/assets/286ee054-bfa2-4fd1-8b2f-f0adba06c67d" />
<img width="1920" height="5480" alt="Image" src="https://github.com/user-attachments/assets/e8acef9d-1058-4d65-a3d9-17e7cb8f7c5c" />
<img width="1920" height="2045" alt="Image" src="https://github.com/user-attachments/assets/f84c6f6c-715e-4e01-b6a6-4266629ff329" />
<img width="1920" height="2030" alt="Image" src="https://github.com/user-attachments/assets/f34f3234-0148-4f56-833f-6209234e7252" />
<img width="1920" height="945" alt="Image" src="https://github.com/user-attachments/assets/f5d2a664-6999-4755-8d24-2e6960a9684e" />
<img width="1920" height="1932" alt="Image" src="https://github.com/user-attachments/assets/36a864c5-d24b-4a53-930e-5a8b07366f7c" />
<img width="1920" height="945" alt="Image" src="https://github.com/user-attachments/assets/2f4a4f6e-87c3-4402-b369-b8af4a8b01a5" />
<img width="1920" height="1056" alt="Image" src="https://github.com/user-attachments/assets/5d616ed9-8026-47be-80e8-361e1b867619" />

## 📁 Proje Yapısı

```
SorbilECommerce/
├── BusinessLayer/          # İş mantığı katmanı
│   ├── Abstract/          # Interface'ler
│   ├── Concrete/          # Service implementasyonları
│   └── FluentValidation/  # Doğrulama kuralları
├── DataAccessLayer/       # Veri erişim katmanı
│   ├── Abstract/          # Repository interface'leri
│   ├── Concrete/          # DbContext
│   ├── EntityFramework/   # EF implementasyonları
│   └── Repository/        # Generic Repository
├── EntityLayer/           # Varlık katmanı
│   └── Concrete/          # Entity sınıfları
└── PresentationLayer/     # Sunum katmanı
    ├── Areas/            # Admin alanı
    ├── Controllers/      # MVC Controller'ları
    ├── Views/           # Razor view'ları
    ├── ViewComponents/   # View Component'leri
    └── wwwroot/         # Statik dosyalar
```


## 📚 Eğitim Amaçları

Bu proje aşağıdaki konuları öğretmek için tasarlanmıştır:

- **Katmanlı Mimari** (Layered Architecture)
- **Repository Pattern**
- **Dependency Injection**
- **Entity Framework Core**
- **ASP.NET Core MVC**
- **CRUD İşlemleri**
- **Form Validation**
- **Admin Panel Geliştirme**

## 📄 Lisans

Bu proje eğitim amaçlı geliştirilmiştir.

## 👨‍💻 Geliştirici

**Sorbil Eğitim Kurumu - Tunahan Cengiz** - Sıfırdan ASP.NET Core Eğitimi
