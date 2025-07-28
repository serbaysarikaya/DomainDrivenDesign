# Domain-Driven Design (DDD) Temel Kavramları

Bu repo, Domain-Driven Design’ın temel yapı taşlarının ve Clean Architecture içindeki yerlerinin örnek kodlarla nasıl uygulanabileceğini gösterir.

---

## DDD Terminolojileri ve Açıklamaları

### Entity
Kendi kimliğine (ID) sahip ve zaman içerisinde değişebilen iş nesneleridir. Kimlikleriyle birbirinden ayırt edilirler, özelliklerindeki değişiklikler kimliği etkilemez.  
**Örnek:** Bir “Kullanıcı” nesnesi, her zaman bir kullanıcı kimliğine (UserId) sahip olmalıdır.

---

### Value Object
Kimliği olmayan, genellikle değişmez (immutable) nesnelerdir. Sadece sahip oldukları değerlere göre eşitlenirler.  
**Örnek:** Bir adres veya para birimi gibi, “Adres” sınıfı iki adres tüm alanları aynıysa eşittir.

---

### Aggregate
Birlikte tutarlılık içinde çalışan bir veya birden fazla Entity ve/veya Value Object’in mantıksal gruplanmasıdır. Her Aggregate’ın, dışarıya açık tek bir girişi olan “Aggregate Root”u (kök nesnesi) vardır. Tüm değişiklikler Aggregate Root üzerinden yapılır.  
**Örnek:** Bir “Sipariş” Aggregate’ı, “Sipariş” (Aggregate Root olarak) ve ona bağlı “Sipariş Kalemleri” entity’lerinden oluşabilir.

---

### Repository
Veri erişim işlemlerinin soyutlandığı arabirim veya sınıftır. Entity ve Aggregate’ların sürekli tutulduğu yerdeki (ör. veritabanı) işlemleri kapsar. Uygulama, veri katmanının detayını bilmeden nesneye erişebilir.  
**Örnek:** `IKullaniciRepository` arayüzü, kullanıcı eklemek, bulmak ve güncellemek gibi işlemler içerir.

---

### Domain Event
Domain’deki önemli bir olay veya durumu temsil eden yapılardır. Sistem içinde tetiklenen bu olaylar; diğer domain nesneleri, uygulama katmanları veya harici servisler tarafından dinlenebilir.  
**Örnek:** “KullanıcıKayıtOldu” domain eventiyle, kullanıcı kaydı sonrası başka işlemler tetiklenebilir.

---

### Service
Domain nesnelerine ait olmayan, genellikle birden fazla nesneyi ilgilendiren, saf iş mantığının uygulanmasını sağlayan yapılardır. Domain Service çoğunlukla karmaşık iş kurallarını barındırır.  
**Örnek:** Bir ödül hesaplama mantığı, tek bir Entity’ye ait değilse bir Service olarak modellenebilir.

---

## Katmanlı Mimari İlişkisi

Klasik Clean Architecture yaklaşımında DDD kavramları;  
- **Domain Katmanında:** Entity, Value Object, Aggregate ve Domain Service’ler  
- **Application Katmanında:** Uygulama hizmetleri ve iş akışları  
- **Infrastructure Katmanında:** Repository implementasyonları  
şeklinde yer alır.

---

## Gereksinimler

- [.NET 9.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- Visual Studio 2022 veya VSCode
- SQL tabanlı bir veritabanı

---

## Kurulum

1. Depoyu klonlayın:
   ```bash
 git clone https://github.com/serbaysarikaya/DomainDrivenDesign.git
   cd DomainDrivenDesign
