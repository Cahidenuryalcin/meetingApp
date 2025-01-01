using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

var builder = WebApplication.CreateBuilder(args);

// 1 mvc şablonunu projeye tanıttık
builder.Services.AddControllersWithViews(); 

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

// app.MapDefaultControllerRoute();
// {controller}/{action}/{id?} şemasını kullandık
// ya da bu şekilde
app.MapControllerRoute(
    name:"default",
    pattern:"{controller=Home}/{action=Index}/{id?}"
);


app.Run();
