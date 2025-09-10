Projenizin Amacı Nedir?
Bu projenin amacı; kullanıcıların güncel filmleri görüntüleyip detaylarını inceleyebileceği, yönetmen ve oyuncu bilgilerinin işlenebileceği, salonların ve film detaylarının yönetilebileceği bir film portalı geliştirmektir. Proje, sinema salonlarında kullanılan yönetim sistemlerinin basitleştirilmiş bir versiyonudur.
Projeniz nasıl bir problemi çözmüştür?
Projede, klasik film listeleme ve gösterim sistemlerinin karmaşıklığı azaltılmış, yönetmen, oyuncu, salon ve film gibi öğelerin merkezi bir panelden kolayca yönetilebilmesi sağlanmıştır. Özellikle küçük çaplı sinemalar veya okul içi etkinliklerde kullanılmak üzere hafif ve yönetilebilir bir çözüm sunmaktadır.
Projeniz tamamen orijinal midir?
•	Orijinal mi?: Evet, proje özgün olarak geliştirilmiştir.
•	Orijinal ise nasıl karar verildi?: Kullanıcı ihtiyaçları, önceki projelerde karşılaşılan zorluklar ve mevcut uygulamaların eksiklikleri göz önüne alınarak bu proje sıfırdan planlandı.
•	Benzerleri var mı?: Evet, örneğin Sinemia veya Biletinial gibi sistemler. Ancak bu projede, sadece yönetici paneli, salon ve içerik yönetimi de bulunmaktadır. Bu yönüyle fark yaratmaktadır.
Projeniz neden önemlidir?
•	Niye bu proje kullanılmalıdır?: Kullanıcı dostu bir arayüzü ve yöneticiye özel kayıt ekranları sayesinde kullanıcılar hem kolayca bilgi alabilir hem de yetkililer sistem üzerinden hızlıca içerik güncelleyebilir.
•	Benzerleri yerine neden bu proje tercih edilmelidir?: Diğer sistemler genellikle ticari amaçlı ve karmaşıktır. Bu proje, özellikle yerel kullanım (okul, kulüp vb.) için idealdir. Ayrıca açık kaynaklıdır ve geliştirilebilir yapıdadır.
Projenizde tamamladığınız hedefler nelerdir?
•	Ana form oluşturuldu.
•	Yönetmen, oyuncu ve salon kayıt ekranları tamamlandı.
•	Film kaydı ve detay görüntüleme sayfası geliştirildi.
•	SQL Server bağlantısı kuruldu ve veriler dinamik şekilde çekildi.
•	Film detay sayfasında puan, vizyon tarihi, resim ve açıklama gibi tüm bilgiler gösterildi.
Projenizde eksik kalan hedefler nelerdir?
•	Kullanıcıların film için bilet ayırtma sistemi henüz entegre edilmedi.
•	Veritabanına kullanıcı giriş/üye olma sistemi eklenemedi.

Projeyi tamamlama aşamanızı grup üyelerinin görevleri ile detaylandırınız
Proje bir kişi tarafından tasarlanmıştır. 
•	Araştırma Süreci:
a.	Benzer sistemlerin arayüz ve işlev analizleri yapıldı.
b.	SQL Server ile bağlantılı sistemler incelendi.
c.	Kullanıcı arayüzleri için Windows Form örnekleri analiz edildi.
Tasarım Süreci ve Kodlama Süreci
Genel Tasarım
1.	FrmAnaForm.cs ile tüm formlar merkezi olarak kontrol edildi.
2.	FrmFilmDetay.cs, FrmYonetmenListesi.cs vb. dosyalarda arama yaparak SqlConnection ile dinamik veri çekildi.
3.	fListesi.cs, oListesi.cs, yListesi.cs, SalonListesi.cs ile her ilgili form için detay ekranına yönlendirme yapıldı.
4.	Görsel öğeler için pbResim gibi kontroller dinamikleştirildi.
5.	Kodlar sade, okunabilir ve yorumlanabilir şekilde geliştirildi.
6.	Tasarım sade ve göz yormayan bir şekilde kullanıcı dostu tasarlandı.
Kodlama Süreci
a.	FrmGiris.cs: Bu formda yönetici şifresi ve yöneticiye ait şifre istenmektedir. Veri tabanına kaydedilmiş yöneticiler sadece giriş yapabilmektedir, bu da belli kişilerin sisteme girebilmesini sağlamasından sebep güvenliği arttırır. 
b.	FrmAnaForm: Bu form tüm formları barındırır. İçerisine atanan butonlarla alt formlara geçiş yapmayı sağlar. Böylelikle bir form üzerinden tüm alt formlara kolaylıkla ulaşılabilir. 
c.	FrmYonetmenKayit: Burada filmlerin yönetmenleri ve onlara ait bilgiler (yaş, biyografi, fotoğraf vb.) kaydedilir.
d.	FrmYonetmenListesi: Kaydedilen yönetmenler veri tabanından yapılan sorgulama ile liste yapısında listelenir. Bu formda arama işlemi de yapılmaktadır.
e.	FrmOyuncuKayit: Burada filmlerin oyuncuları ve onlara ait bilgiler (yaş, biyografi, fotoğraf vb.) kaydedilir.
f.	FrmOyuncuListesi: Kaydedilen oyuncular ve onlara ait bilgiler veri tabanından yapılan sorgulama ile liste biçiminden listelenir. Arama işlemi de gerçekleştirilebilir. 
g.	FrmSalonKayit.cs: Burada salon bilgileri (kaç kişilik, kaçıncı salon) girilir.
h.	FrmSalonListesi.cs: Salon sorgulama işlemi gerçekleştirilir. 
i.	FrmFilmKayit: Yayınlanacak filmler ve onlara ait bilgiler (afiş, vizyon tarihi, oyuncuları, yönetmenleri vb.) kaydedilir. Burada dikkat edilmesi gereken şey, vizyon tarihi kaydedilirken geçmişe yönelik bir kaydetme yapılamaz. Ya o günün tarihi ya da daha sonrası olması gerekmektedir. 
j.	FrmFilmListesi: Filmlerin afişleri ve isimleri ile listelendiği form yapısıdır. Detay butonuna basıldığında o film ile ilgili kaydedilen tüm bilgiler görünmektedir. 
k.	oListesi.cs, yListesi.cs ve SalonListesi.cs: Burada aynı kodları sürekli yazmamak adına UserControls yapısı kullanılmıştır ve bir liste yapısı oluşturulmuştur. Ardından FrmYonetmenListesi gibi sayfalarda bu UserControls yapıları kullanılarak kayıtlar listelenmiştir. 
