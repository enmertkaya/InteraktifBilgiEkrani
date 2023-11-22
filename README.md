![](images/intekran.png)

Bu projede, genel olarak fakültemizin belirli yerlerine konumlandırılmış ekranlarda
öğretim elemanları, öğrenciler, çalışan ve ziyaretçiler için güncel, hızlı ve interaktif bir
şekilde bilgi akış ekranı tasarlanmıştır. Anlık ve hızlı bilgi akışının yanında oryantasyon
oyunları, etkinlik haberleri, özel gün kutlamaları, doğal afet ve acil durumlar anında
anlık tahliye ve bilgilendirme aracı olarak da kullanılabilir.

### 1-Admin/Yönetici Rolü 

* :ear: ​**Kullanıcı İşlemleri :** Yönetici **Interaktif Bilgi Ekranı** aracılığı ile kullanıcı ekleyebilir, silebilir.Admin rolüne giriş için ;
* Kullanıcı adı : admin@gmail.com  Şifre: 123
  ![](images/admingiriss.png)
  Admin rolü ile giriş yapan kullanıcı , fakültede uygulamayı kullanmak isteyen kişileri oluşturup silme yetkisi vardır.İstenilen fakültede yetkili kişiyi oluşturup default bir şifre atar. Kullanıcılar kayıt oldukları mail adreslerine yeni şifre talebi gönderebilir. Şifreler mssql database üzerinden md-5 ile kriptolanmış bir şekilde tutulur.
  ![](images/adminislem.png)
  Yeni kullanıcı ekleme ekranından fakülte ve yetkinlik seçilip yeni kullanıcı oluşturulur.
  ![](images/adminekran.png)
  
### 2-Co-Admin/Yardımcı Yönetici Rolü 

:house:​**Co-Admin İşlemleri  :** Yardımcı Yönetici ** Üniversite içinde yeni bölüm ekleyebilir.(Yeni bölümlerde olan ekranları kullanmak için.)
 ![](images/yenibolum.png)
 **Yeni Fakülte oluşturabilir ;
 ![](images/yenifakulte.png)
 **Yeni TV ekranları oluşturabilir.( Tv id'lerine göre haber ekleyebilmek için)
 ![](images/yenitv.png)
 **Ekranlarda gösterilmek üzere yeni haber , foto , bilgi girişi yapabilir.
 ![](images/haberislemleri.png)
 ![](images/habergosterim.png)
 
### 3- Kullanıcı Rolü

* :ear:: **Duyuru İşlemleri :** Kullanıcı **İnteraktif Bilgi Ekrani** aracılığı ile duyuruları görüntüleyebilir.

* :dollar: **Önemli Gün ve Etkinlikler :** Kullanıcı **İnteraktif Bilgi Ekrant** aracılığı ile etkinlik ve üniversite içinde olan etkinliklerden anlık olarak haberdar olabilir.
* :package:**Mesaj İşlemleri :** Kullanıcı **İnteraktif Bilgi Ekrant** aracılığı ile anlık olarak mesaj ve görüntü bilgisi ile bilgi aktarımı sağlayabilir.

  ## :computer: Projenin Kurulumu

   Proje’yi çalıştırmak için SQL Server Management Studio Management Studio 19’ın bilgisayarınızda yüklü olması gerekmektedir. Bu kurulumu tamamladıktan sonra veritabanlarımızın yerel sunucumuzda oluşmasını sağlamak için projemizi açıyoruz. Başlangıç projemizi **Kurumsal.Web** olarak belirledikten sonra package manager console’umuzda varsayılan projemizi **KurumsalWeb** olarak belirliyor ve **update-database** komutunu giriyoruz.Bu işlemden sonra veritabanımız yerel sunucumuz içerisinde oluşuyor.

  **Projeye Ait İlişkili Veri Tabanı ve diğer görseller ;

![](images/1.png)
![](images/vt.png)
![](images/sifresil.png)
![](images/5.png)
<h2> 🛠 &nbsp;Kullanılan Teknolojiler</h2>

<img alt="GIF" src="https://i.pinimg.com/originals/e4/26/70/e426702edf874b181aced1e2fa5c6cde.gif" />

<table style"float:right;">
  <tr>
    <td><img src="https://img.shields.io/badge/-JavaScript-black?style=flat&logo=javascript"/></td>
    <td><img src="https://img.shields.io/badge/-HTML5-E34F26?style=flat&logo=html5&logoColor=white"></td>
    <td><img src="https://img.shields.io/badge/-Identity-5C2D91?style=flat&logo=.net&logoColor=white"/></td>
  </tr>
  <tr>
    <td><img src="https://img.shields.io/badge/-FluentValidation-CC2927?style=flat-square&logo=.net&logoColor=ffffff"/></td>
    <td><img src="https://img.shields.io/badge/-AutoMapper-5C2D91?style=flat&logo=.net&logoColor=white"/</td>
    <td><img src="https://img.shields.io/badge/-EntityFramework-5C2D91?style=flat&logo=.net&logoColor=white"/><img src="https://img.shields.io/badge/-ASP.NET-5C2D91?style=flat&logo=.net&logoColor=white"/></td>
  </tr>
  <tr>
    <td> <img src="https://img.shields.io/badge/-Git-black?style=flat&logo=git"/></td>
    <td><img src="https://img.shields.io/badge/-json-02569B?style=flat&logo=json"/></td>
  </tr>
  <tr>
    <td><img src="https://img.shields.io/badge/-Bootstrap-563D7C?style=flat&logo=bootstrap"/></td>
 		<td><img src="https://img.shields.io/badge/-CSS3-1572B6?style=flat&logo=css3"/></td>
    <td><img src="https://img.shields.io/badge/-Sql%20Server-CC2927?style=flat-square&logo=microsoft-sql-server&logoColor=ffffff"/></td>
  </tr>
</table>







 
