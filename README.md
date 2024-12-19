# Patika Code First Basic - Entity Framework Core Projesi

Bu proje, Entity Framework Core kullanılarak Code First yaklaşımıyla oluşturulan bir veritabanı uygulamasıdır. 
Projede, Movie ve Game olmak üzere iki bağımsız tablo bulunmaktadır. Uygulama, basit ve öğrenme odaklı bir şekilde Code First metodolojisini uygulamayı hedeflemektedir.

 ## 📂 Proje İçeriği

#### Movies Tablosu

- **Id**: int, birincil anahtar ve otomatik artan.
- **Title**: string, filmin başlığı.
- **Genre**: string, filmin türü (örneğin: "Action", "Comedy", "Drama").
- **ReleaseYear**: int, filmin çıkış yılı.

#### Games Tablosu

- **Id**: int, birincil anahtar ve otomatik artan.
- **Name**: string, oyunun adı.
- **Platform**: string, oyunun oynandığı platform (örneğin: "PC", "PlayStation", "Xbox").
- **Rating**: decimal, oyunun puanı (0 ile 10 arasında).

 #### Veritabanı
 - Veritabanı İsmi: PatikaCodeFirstDb1
 - Context Sınıfı: PatikaFirstDbContext
   
 ## 🚀 Kurulum ve Çalıştırma
1. Gerekli NuGet Paketlerini Yükleme
Proje dizininde aşağıdaki komutları çalıştırarak gerekli paketleri yükleyin:

````
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package Npgsql.EntityFrameworkCore.PostgreSQL 
````





