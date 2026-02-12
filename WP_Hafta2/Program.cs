var builder = WebApplication.CreateBuilder(args);

//Controller ve Viewlarý projeye ekle
builder.Services.AddControllersWithViews();

var app = builder.Build();

//app.MapGet("/", () =>
//{
//    //int a = 10;
//    //int b = 20;

//    return "Web Tabanlý Programlama Dersi";

//});

app.MapControllerRoute(
    name:"default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
