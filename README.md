# ShopMngr

Merhaba,

Proje temel 4 katmandan oluşuyor. 

1. Model Katmanı: DTO modeller özelleştirilebilir db bağımsız olan modellerdir, DTO olmayanlarda entitiy framework yada db bağlantısı yapılacak ORM ler için base class lardır.

2.DataAcces Katmanı: Bir veritabanı bağlantısı olmadığı için mevcut bir contex kullanılabilir değil fakat örneklerin veri modellerini üzerinde tutması için 6 dakika ömürlü memory cash kullandım. Repository Pattern ile hem db için gereken CRUD işlemler dışında extra olan işlemler için soyutlanan nesneler oluşturdum.

3.Bussines Katmanı: Bu katmanda DataAccess üzerindeki verilerin alınmasından sonra işlenmesi ve hesaplamaların yapılması için yine soyut nesnelerle mümkün olduğunca bağımsız nesneler oluşturdum.

4.Api Katmanı: Controller Constructor da memory cash tanımlayıp ilk aşamada doldurulmasını sağladıktan sonra diğer Actionlar çağırıldığında bu verilerin işlenmesi sağlandı.

5.ShopsRUs.MSTest: Controller yada diğer katmanlar için ayrı ayrı test classları mevcuttur ve burda her method test edilebilir durumdadır.


Temel model yapıları aşağıdaki gibidir.

1.UserCategory:Kullanıcı türünü tanımlayan objedir.

2.User : Kullanıcı tanımı için kullanılan obje. Kullanıcının birden fazla kategorisi olabilir.

3.Discount: Faturalarda kullanıcıların kategorilerine verilen indirimlerin tanımlandığı objedir. Kullanının kategorisine bağlı olarak bloklanmış bir discount türü tanımlanmamışsa "en yüksek oran" olan discount işlenir.

4.DiscountType: Yüzde, Tutara Bağlı Yüzde yada sonradan tanımlanacak sabit indirimler gibi indirim türlerinin tanımlandığı obje. Burda sadece yüzde ve tutar üzerinden yüzde indirimi olmak üzere 2 tür vardır.

5.Invoice: Fatura tanımlamak için kullanılan objedir. İçerisinde hem User hemde Discount bilgilerini barındırır. Kullanıcı kategorilerine bağlı olarak birden fazla discount varsa yüksek olanı işler. Bloklanmış olan varsa kaç tane Discount tanımlı olursa olsun işlenmez. Bu işlemler için İnvice modelide ICalculate interface den türemiş sınıflar hesaplamaları yapar ve günceller.


Controller üzerinden test işlemleri

1.İlk başlatıldığında memory cache üzerinde objeler dolması için otomatik olarak gelen endpoint
https://localhost:44380/api/InvoiceDiscount/SetDataToMemory

2.User Category List çekilmesi için aşağıdaki endpoint 
https://localhost:44380/api/InvoiceDiscount/GetUserCategoryList

3.User List çekmek için 
https://localhost:44380/api/InvoiceDiscount/GetUserList

4.Uygulanan indirimleri görmek için 
https://localhost:44380/api/InvoiceDiscount/GetDiscountList

5.Tüm kobinasyonların uygulandığı InvoiceList çekmek için 
https://localhost:44380/api/InvoiceDiscount/GetInvoiceList

6.Bir Fatura bilgisi görülmek istendiğinde 
https://localhost:44380/api/InvoiceDiscount/GetInvoice?invoiceID=4

7.Bir faturaya indirim uygulandığında yapılacak hesaplama için 
https://localhost:44380/api/InvoiceDiscount/SetInvoiceDiscount?invoiceID=4







