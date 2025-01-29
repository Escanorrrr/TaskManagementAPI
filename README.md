# Task Management API

Bu proje, kullanıcıların kişisel görevlerini yönetebilecekleri bir RESTful API'dir. .NET 9.0 kullanılarak geliştirilmiştir.

## 🚀 Özellikler

- Kullanıcı kayıt ve giriş sistemi
- JWT tabanlı kimlik doğrulama
- Görev oluşturma, okuma, güncelleme ve silme (CRUD) işlemleri
- Görevleri tamamlanma durumuna göre filtreleme
- PostgreSQL veritabanı entegrasyonu
- Swagger/OpenAPI dokümantasyonu

## 🛠️ Kullanılan Teknolojiler

- **.NET 9.0**
- **ASP.NET Core Web API**
- **Entity Framework Core**
- **PostgreSQL**
- **JWT (JSON Web Token)**
- **Swagger/OpenAPI**
- **BCrypt.Net-Next** (şifre hashleme)

## 📦 Veritabanı Yapısı

### Users Tablosu
- Id (int, primary key)
- Email (string, unique)
- PasswordHash (string)
- CreatedAt (datetime)

### Tasks Tablosu
- Id (int, primary key)
- Title (string)
- Description (string)
- IsCompleted (boolean)
- CreatedAt (datetime)
- UserId (int, foreign key)

## 🔗 API Endpoints

### Kimlik Doğrulama
- `POST /api/auth/register` - Yeni kullanıcı kaydı
- `POST /api/auth/login` - Kullanıcı girişi

### Görev Yönetimi
- `GET /api/tasks` - Tüm görevleri listele
- `GET /api/tasks/{id}` - Belirli bir görevi getir
- `POST /api/tasks` - Yeni görev oluştur
- `PUT /api/tasks/{id}` - Görevi güncelle
- `DELETE /api/tasks/{id}` - Görevi sil

## 🚀 Kurulum

1. Projeyi klonlayın:
\`\`\`bash
git clone [repository-url]
\`\`\`

2. PostgreSQL'i yükleyin ve çalıştırın

3. appsettings.json dosyasındaki veritabanı bağlantı bilgilerini güncelleyin:
\`\`\`json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Database=TaskManagementDb;Username=postgres;Password=your_password"
  }
}
\`\`\`

4. Migration'ları uygulayın:
\`\`\`bash
dotnet ef database update
\`\`\`

5. Projeyi çalıştırın:
\`\`\`bash
dotnet run
\`\`\`

## 🔒 Güvenlik

- JWT tabanlı kimlik doğrulama
- Şifrelerin BCrypt ile hashlenip saklanması
- Email adresi benzersizliği kontrolü
- HTTPS zorunluluğu
- CORS politikası yapılandırması

## 📝 API Kullanımı

### Kullanıcı Kaydı
\`\`\`http
POST /api/auth/register
Content-Type: application/json

{
  "email": "user@example.com",
  "password": "password123"
}
\`\`\`

### Kullanıcı Girişi
\`\`\`http
POST /api/auth/login
Content-Type: application/json

{
  "email": "user@example.com",
  "password": "password123"
}
\`\`\`

### Yeni Görev Oluşturma
\`\`\`http
POST /api/tasks
Authorization: Bearer [token]
Content-Type: application/json

{
  "title": "Örnek Görev",
  "description": "Bu bir örnek görev açıklamasıdır"
}
\`\`\`

## 🛠️ Geliştirme Aşamaları

1. Proje yapısının oluşturulması
2. Entity modellerinin tasarlanması
3. DbContext ve migration yapılandırması
4. JWT authentication sisteminin kurulması
5. Controller'ların implementasyonu
6. Swagger dokümantasyonunun eklenmesi
7. CORS ve güvenlik yapılandırmaları
8. Test ve hata düzeltmeleri

## 📚 Swagger Dokümantasyonu

API dokümantasyonuna erişmek için uygulamayı çalıştırdıktan sonra `/swagger` endpoint'ini ziyaret edin.

## 🤝 Katkıda Bulunma

1. Bu repository'yi fork edin
2. Feature branch'i oluşturun (`git checkout -b feature/amazing-feature`)
3. Değişikliklerinizi commit edin (`git commit -m 'feat: Add some amazing feature'`)
4. Branch'inizi push edin (`git push origin feature/amazing-feature`)
5. Pull Request oluşturun

## 📄 Lisans

Bu proje MIT lisansı altında lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasına bakın. 
