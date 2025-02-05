var builder = WebApplication.CreateBuilder(args);

//MVC servislerini ekliyoruz.

builder.Services.AddControllersWithViews();

var app = builder.Build();

//Statik dosyalar�n kullan�m�n�n belirtiyoruz.
app.UseStaticFiles();

//Routing Konfig�rasyonu(yap�land�r�lmas�)
app.UseRouting();

//Varsay�lan(default) Routing tan�mlayal�m.


app.MapControllers(); 
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();





/*
                        KAVRAMLARIN A�IKLAMALARI

1- Controller: Kullan�c�n�n iste�ine ba�l� olarak belirli i�lemleri ger�ekle�tiren 
ve model ile view aras�ndaki ba�lant�y� sa�layan bile�endir.

2- Action(METOT): Controller i�inde tan�mlanan ve belirli bir iste�i i�leyen metotlard�r.

3- Model(CLASS): Veri yap�lar�n�n tan�mland��� ve i� kurallar�n�n belirlendi�i bile�endir.

4- View: Kullan�c�ya sunulacak aray�z�n olu�turuldu�u dosyalard�r.

5- Razor: ASP.NET Core'un dinamik HTML olu�turmak i�in kullan�lan �ablon motorudur.

6- RazorView: Razor motoru taraf�ndan i�lenen ve kullan�c�ya g�sterilen HTML sayfas�d�r.

7- wwwroot: Statik dosyalar�n (CSS, JavaScript, resimler vb.) bulundu�u klas�rd�r.

8- builder.Build(): Uygulaman�n yap�land�rmas�n� tamamlar ve �al��t�r�lmaya haz�r hale getirir.

9- app.Run(): Uygulamay� �al��t�rarak gelen HTTP isteklerini dinlemeye ba�lar.

*/

