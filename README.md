🎬🎮 Code First ile Veri Tabanı Oluşturma – Entity Framework Core
Bu proje, Entity Framework Core kullanarak Code First yaklaşımıyla bir veri tabanı oluşturmayı amaçlamaktadır. Uygulamada iki bağımsız tablo yer alır: Movies ve Games.

📦 Kullanılan Teknolojiler
.NET Core

Entity Framework Core

SQL Server (ya da başka bir EF uyumlu veritabanı)

🧱 Veri Tabanı Yapısı
🎥 Movie Tablosu (Movies)
Alan	Tür	Açıklama
Id	int	Birincil anahtar, otomatik artan
Title	string	Filmin başlığı
Genre	string	Türü (ör: Action, Comedy, Drama)
ReleaseYear	int	Çıkış yılı

🎮 Game Tablosu (Games)
Alan	Tür	Açıklama
Id	int	Birincil anahtar, otomatik artan
Name	string	Oyunun adı
Platform	string	Platform (ör: PC, PlayStation, Xbox)
Rating	decimal	Puan (0 – 10 arası)

🧠 DbContext
Veritabanı işlemleri PatikaFirstDbContext sınıfı üzerinden gerçekleştirilir. Bu sınıf, DbSet<Movie> ve DbSet<Game> koleksiyonları ile Movies ve Games tablolarını temsil eder.
