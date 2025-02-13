var builder = WebApplication.CreateBuilder(args);

//MVC servislerini ekliyoruz.

builder.Services.AddControllersWithViews();

var app = builder.Build();

//Statik dosyaların kullanımının belirtiyoruz.
app.UseStaticFiles();

//Routing Konfigürasyonu(yapılandırılması)
app.UseRouting();

//Varsayılan(default) Routing tanımlayalım.


app.MapControllers(); 
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();





/*
                        KAVRAMLARIN AÇIKLAMALARI

1- Controller: Kullanıcının isteğine bağlı olarak belirli işlemleri gerçekleştiren 
ve model ile view arasındaki bağlantıyı sağlayan bileşendir.

2- Action(METOT): Controller içinde tanımlanan ve belirli bir isteği işleyen metotlardır.

3- Model(CLASS): Veri yapılarının tanımlandığı ve iş kurallarının belirlendiği bileşendir.

4- View: Kullanıcıya sunulacak arayüzün oluşturulduğu dosyalardır.

5- Razor: ASP.NET Core'un dinamik HTML oluşturmak için kullanılan şablon motorudur.

6- RazorView: Razor motoru tarafından işlenen ve kullanıcıya gösterilen HTML sayfasıdır.

7- wwwroot: Statik dosyaların (CSS, JavaScript, resimler vb.) bulunduğu klasördür.

8- builder.Build(): Uygulamanın yapılandırmasını tamamlar ve çalıştırılmaya hazır hale getirir.

9- app.Run(): Uygulamayı çalıştırarak gelen HTTP isteklerini dinlemeye başlar.

*/

