var builder = WebApplication.CreateBuilder(args);

//MVC servislerini ekliyoruz.

builder.Services.AddControllersWithViews();

var app = builder.Build();

//Statik dosyalarýn kullanýmýnýn belirtiyoruz.
app.UseStaticFiles();

//Routing Konfigürasyonu(yapýlandýrýlmasý)
app.UseRouting();

//Varsayýlan(default) Routing tanýmlayalým.


app.MapControllers(); 
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();





/*
                        KAVRAMLARIN AÇIKLAMALARI

1- Controller: Kullanýcýnýn isteðine baðlý olarak belirli iþlemleri gerçekleþtiren 
ve model ile view arasýndaki baðlantýyý saðlayan bileþendir.

2- Action(METOT): Controller içinde tanýmlanan ve belirli bir isteði iþleyen metotlardýr.

3- Model(CLASS): Veri yapýlarýnýn tanýmlandýðý ve iþ kurallarýnýn belirlendiði bileþendir.

4- View: Kullanýcýya sunulacak arayüzün oluþturulduðu dosyalardýr.

5- Razor: ASP.NET Core'un dinamik HTML oluþturmak için kullanýlan þablon motorudur.

6- RazorView: Razor motoru tarafýndan iþlenen ve kullanýcýya gösterilen HTML sayfasýdýr.

7- wwwroot: Statik dosyalarýn (CSS, JavaScript, resimler vb.) bulunduðu klasördür.

8- builder.Build(): Uygulamanýn yapýlandýrmasýný tamamlar ve çalýþtýrýlmaya hazýr hale getirir.

9- app.Run(): Uygulamayý çalýþtýrarak gelen HTTP isteklerini dinlemeye baþlar.

*/

