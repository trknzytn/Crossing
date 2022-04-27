# ShopMngr

Merhaba,

Proje temel 4 katmandan oluþuyor. 

1. Model Katmaný: DTO modeller özelleþtirilebilir db baðýmsýz olan modellerdir, DTO olmayanlarda entitiy framework yada db baðlantýsý yapýlacak ORM ler için base class lardýr.

2.DataAcces Katmaný: Bir veritabaný baðlantýsý olmadýðý için mevcut bir contex kullanýlabilir deðil fakat örneklerin veri modellerini üzerinde tutmasý için 6 dakika ömürlü memory cash kullandým. Repository Pattern ile hem db için gerken CRUD iþlemler dýþýnda extra olan iþlemler için soyutlanan nesneler oluþturdum.

3.Bussines Katmaný: Bu katmanda DataAccess üzerindeki verilerin alýnmasýndan sonra iþlenmesi ve hesaplamalarýn yapýlmasý için yine soyut nesnelerle mümkün olduðunca baðýmsýz nesneler oluþturdum.

4.Api Katmaný: Controller Constructor da memory cash tanýmlayýp ilk aþamada doldurulmasýný saðladýktan sonra diðer Actionlar çaðýrýldýðýnda bu verilerin iþlenmesi saðlandý.

5.ShopsRUs.MSTest: Controller yada diðer katmanlar için ayrý ayrý test classlarý mevcuttur ve burda her method test edilebilir durumdadýr.


Temel model yapýlarý aþaðýdaki gibidir.

1.UserCategory:Kullanýcý türünü tanýmlayan objedir.

2.User : Kullanýcý tanýmý için kullanýlan obje. Kullanýcýnýn birden fazla kategorisi olabilir.

3.Discount: Faturalarda kullanýcýlarýn kategorilerine verilen indirimlerin tanýmlandýðý objedir. Kullanýnýn kategorisine baðlý olarak bloklanmýþ bir discount türü tanýmlanmamýþsa "en yüksek oran" olan discount iþlenir.

4.DiscountType: Yüzde, Tutara Baðlý Yüzde yada sonradan tanýmlanacak sabit indirimler gibi indirim türlerinin tanýmlandýðý obje. Burda sadece yüzde ve tutar üzerinden yüzde indirimi olmak üzere 2 tür vardýr.

5.Invoice: Fatura tanýmlamak için kullanýlan objedir. Ýçerisinde hem User hemde Discount bilgilerini barýndýrýr. Kullanýcý kategorilerine baðlý olarak birden fazla discount varsa yüksek olaný iþler. Bloklanmýþ olan varsa kaç tane Discount tanýmlý olursa olsun iþlenmez. Bu iþlemler için Ýnvice modelide ICalculate interface den türemiþ sýnýflar hesaplamalarý yapar ve günceller.


Controller üzerinden test iþlemleri

1.Ýlk baþlatýldýðýnda memory cache üzerinde objeler dolmasý için otomatik olarak gelen endpoint
https://localhost:44380/api/InvoiceDiscount/SetDataToMemory

2.User Category List çekilmesi için aþaðýdaki endpoint 
https://localhost:44380/api/InvoiceDiscount/GetUserCategoryList

3.User List çekmek için 
https://localhost:44380/api/InvoiceDiscount/GetUserList

4.Uygulanan indirimleri görmek için 
https://localhost:44380/api/InvoiceDiscount/GetDiscountList

5.Tüm kobinasyonlarýn uygulandýðý InvoiceList çekmek için 
https://localhost:44380/api/InvoiceDiscount/GetInvoiceList

6.Bir Fatura bilgisi görülmek istendiðinde 
https://localhost:44380/api/InvoiceDiscount/GetInvoice?invoiceID=4

7.Bir faturaya indirim uygulandýðýnda yapýlacak hesaplama için 
https://localhost:44380/api/InvoiceDiscount/SetInvoiceDiscount?invoiceID=4








