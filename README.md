# 🏥 Hasta Kayıt ve Muayene Yönetim Sistemi

## 📌 Proje Hakkında
Bu proje, bir sağlık ocağındaki doktorun hasta kayıtlarını, muayene kayıtlarını, reçeteleri ve ilaç bilgilerini yönetebilmesini sağlamak amacıyla geliştirilmiştir. C# ile masaüstü uygulama olarak yazılmıştır.

## 🛠️ Teknolojiler ve Gereksinimler
- **Programlama Dili:** C#
- **Platform:** Windows
- **Geliştirme Ortamı:** Visual Studio
- **Veritabanı:** PostgreSQl / MSSQL (Kullanım durumuna göre değiştirilebilir)


2. **Visual Studio ile Açın**
   - `HastaKayitSistemi.sln` dosyasını Visual Studio ile açın.

3. **Bağımlılıkları Yükleyin**
   - Eğer proje veritabanı kullanıyorsa, gerekli bağlantı ayarlarını yapın.

4. **Projeyi Çalıştırın**
   - Debug veya Release modunda projeyi çalıştırarak test edin.

## 📖 Kullanım Adımları
1. **Hasta Kaydı:**
   - Yeni bir hasta sisteme eklenir.
   - Eğer hasta daha önce kayıtlıysa, uyarı mesajı görüntülenir.

2. **Muayene Kaydı:**
   - Bir hastanın günlük yalnızca bir muayene kaydı olabilir.
   - Muayene kaydı oluşturulmadan reçete eklenemez.

3. **Reçete Yönetimi:**
   - Bir hastanın bir gün içinde yalnızca tek bir reçetesi olabilir.
   - Reçete oluşturmak için ilgili muayene kaydının bulunması gerekir.

4. **İlaç Yönetimi:**
   - Doktor hastaya yazılan ilaçları görüntüleyebilir.
   - Yeni ilaçlar sisteme eklenebilir.

## 🔍 Algoritma
1. Kullanıcı hasta bilgilerini girer.
2. Hasta bilgisi mevcutsa, hata mesajı döndürülür.
3. Hasta kaydı tamamlandıysa, muayene kaydı oluşturulur.
4. Muayene kaydı olan hastalar için reçete kaydı eklenebilir.
5. Doktor hastaya yazılan ilaçları görüntüleyebilir ve sisteme yeni ilaç ekleyebilir.

## 🤝 Katkıda Bulunma
Projeye katkıda bulunmak isterseniz, lütfen bir **issue** açın veya bir **pull request** gönderin.


