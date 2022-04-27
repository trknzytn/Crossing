# ShopMngr

Merhaba,

Proje temel 4 katmandan olu�uyor. 

1. Model Katman�: DTO modeller �zelle�tirilebilir db ba��ms�z olan modellerdir, DTO olmayanlarda entitiy framework yada db ba�lant�s� yap�lacak ORM ler i�in base class lard�r.

2.DataAcces Katman�: Bir veritaban� ba�lant�s� olmad��� i�in mevcut bir contex kullan�labilir de�il fakat �rneklerin veri modellerini �zerinde tutmas� i�in 6 dakika �m�rl� memory cash kulland�m. Repository Pattern ile hem db i�in gerken CRUD i�lemler d���nda extra olan i�lemler i�in soyutlanan nesneler olu�turdum.

3.Bussines Katman�: Bu katmanda DataAccess �zerindeki verilerin al�nmas�ndan sonra i�lenmesi ve hesaplamalar�n yap�lmas� i�in yine soyut nesnelerle m�mk�n oldu�unca ba��ms�z nesneler olu�turdum.

4.Api Katman�: Controller Constructor da memory cash tan�mlay�p ilk a�amada doldurulmas�n� sa�lad�ktan sonra di�er Actionlar �a��r�ld���nda bu verilerin i�lenmesi sa�land�.

5.ShopsRUs.MSTest: Controller yada di�er katmanlar i�in ayr� ayr� test classlar� mevcuttur ve burda her method test edilebilir durumdad�r.


Temel model yap�lar� a�a��daki gibidir.

1.UserCategory:Kullan�c� t�r�n� tan�mlayan objedir.

2.User : Kullan�c� tan�m� i�in kullan�lan obje. Kullan�c�n�n birden fazla kategorisi olabilir.

3.Discount: Faturalarda kullan�c�lar�n kategorilerine verilen indirimlerin tan�mland��� objedir. Kullan�n�n kategorisine ba�l� olarak bloklanm�� bir discount t�r� tan�mlanmam��sa "en y�ksek oran" olan discount i�lenir.

4.DiscountType: Y�zde, Tutara Ba�l� Y�zde yada sonradan tan�mlanacak sabit indirimler gibi indirim t�rlerinin tan�mland��� obje. Burda sadece y�zde ve tutar �zerinden y�zde indirimi olmak �zere 2 t�r vard�r.

5.Invoice: Fatura tan�mlamak i�in kullan�lan objedir. ��erisinde hem User hemde Discount bilgilerini bar�nd�r�r. Kullan�c� kategorilerine ba�l� olarak birden fazla discount varsa y�ksek olan� i�ler. Bloklanm�� olan varsa ka� tane Discount tan�ml� olursa olsun i�lenmez. Bu i�lemler i�in �nvice modelide ICalculate interface den t�remi� s�n�flar hesaplamalar� yapar ve g�nceller.


Controller �zerinden test i�lemleri

1.�lk ba�lat�ld���nda memory cache �zerinde objeler dolmas� i�in otomatik olarak gelen endpoint
https://localhost:44380/api/InvoiceDiscount/SetDataToMemory

2.User Category List �ekilmesi i�in a�a��daki endpoint 
https://localhost:44380/api/InvoiceDiscount/GetUserCategoryList

3.User List �ekmek i�in 
https://localhost:44380/api/InvoiceDiscount/GetUserList

4.Uygulanan indirimleri g�rmek i�in 
https://localhost:44380/api/InvoiceDiscount/GetDiscountList

5.T�m kobinasyonlar�n uyguland��� InvoiceList �ekmek i�in 
https://localhost:44380/api/InvoiceDiscount/GetInvoiceList

6.Bir Fatura bilgisi g�r�lmek istendi�inde 
https://localhost:44380/api/InvoiceDiscount/GetInvoice?invoiceID=4

7.Bir faturaya indirim uyguland���nda yap�lacak hesaplama i�in 
https://localhost:44380/api/InvoiceDiscount/SetInvoiceDiscount?invoiceID=4








