# Easy Cash - Identity & N-Tier Architecture Project

Bu proje, Murat Yücedağ'ın "Easy Cash" eğitim serisi referans alınarak, kurumsal yazılım geliştirme prensiplerine uygun olarak geliştirilmiş bir **Kimlik Doğrulama (Authentication) ve Yetkilendirme (Authorization)** altyapı projesidir. Proje, esnek ve sürdürülebilir bir yapı sunması amacıyla **N-Tier (Çok Katmanlı) Mimari** üzerine inşa edilmiştir.

## 🛠️ Kullanılan Teknolojiler & Kütüphaneler
* **Backend:** .NET 6.0 / C#
* **ORM & Database:** Entity Framework Core, SQL Server
* **Identity Management:** ASP.NET Core Identity
* **Validation:** FluentValidation
* **Architecture:** N-Tier Architecture (Presentation, Business, Data Access, DTO, Entity)

---

## 📐 Mimari Yapı (N-Tier Architecture)

Proje 5 ana katmandan oluşmaktadır:

1. **Entity Layer:** Veri tabanı tablolarına karşılık gelen sınıfların ve Identity entegrasyonu için özelleştirilmiş `AppUser` ve `AppRole` sınıflarının yer aldığı katman.
2. **Data Access Layer (DAL):** Entity Framework Core konfigürasyonlarının, `Context` sınıfının ve migrations yönetildiği katman.
3. **Dto Layer (Data Transfer Object):** Katmanlar arası veri taşınırken güvenliği ve performansı sağlamak amacıyla kullanılan nesnelerin yer aldığı katman. Veri tabanı varlıklarının (`Entity`) doğrudan dış dünyaya açılmasını engelleyerek sadece gerekli alanların (`Örn: AppUserRegisterDto`, `AppUserEditDto`) taşınmasını sağlar.
4. **Business Layer:** resentation katmanından gelen **DTO** nesneleri, iş katmanında `FluentValidation` kuralları ile denetlenir.
5. **Presentation Layer (MVC):** Kullanıcı arayüzünün, Controller yapılarının ve View bileşenlerinin yer aldığı, kullanıcı ile etkileşime geçilen katman.

---

## 🔐 Öne Çıkan Özellikler ve Güvenlik Altyapısı

### 1. ASP.NET Core Identity Entegrasyonu
* **Custom Identity:** Varsayılan `IdentityUser` sınıfı genişletilerek projeye özgü kullanıcı alanları mimariye dahil edilmiştir.
* **Güvenli Şifreleme:** Şifreler veri tabanında açık metin (plain text) olarak değil, Identity'nin `IPasswordHasher` mekanizmasıyla hash'lenerek saklanmaktadır.


