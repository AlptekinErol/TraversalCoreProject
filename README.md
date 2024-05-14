Bu proje, .NET Core kullanılarak geliştirilmiş olup, gezi ayarlamak ve tur rehberleri ayarlamak için bir platform sağlar. 
Projede Repository Pattern kullanılmış olup, veri erişim işlemleri soyutlanmıştır. 
Kullanıcı kimlik doğrulama ve yetkilendirme işlemleri için Identity kütüphanesi, MSSQL veritabanı ve Entity Framework Core (Code First yaklaşımıyla) kullanılmıştır.
Ayrıca, kullanıcıların rotaları sayfasında görecekleri detaylı bilgilerin işlenmesi için CQRS (Command Query Responsibility Segregation) dizayn pattern'i uygulanmıştır. 
Bu sayede, yazma (write) ve okuma (read) işlemleri ayrı olarak ele alınarak performans artırılmış ve sistem üzerindeki yük dengelenmiştir. 
Admin panelinde, sitenin kaç kişi ve hangi şehirlerden girdiğini gerçek zamanlı olarak gösteren bir chart uygulaması SignalR kütüphanesiyle entegre edilmiştir.
Projede ayrıca, kullanıcıların seyahat planlarını oluştururken otel araması yapmalarını sağlayan bir API entegrasyonu bulunmaktadır
. Bu API sayesinde kullanıcılar, destinasyonlarını seçip belirli tarihler için otel arayabilir ve rezervasyon yapabilirler.
2. Bir Api ise sisteme giriş yapan kullanıcıların verilerini MsSQL Veritabanına kaydederek kullanım oranı/ülke analizi yapmak için kullanılabilir , bu api yeni bir repo üzerinden paylaşıldı.

Not: Bu proje bir eğitim projesidir. Kullanılan diğer kütüphaneler ve mimariler için bu YouTube playlistini https://www.youtube.com/watch?v=ZblVzj04LtM&list=PLKnjBHu2xXNMK5MBogdXmsXVi3K_eEZT5 izleyebilirsiniz.
