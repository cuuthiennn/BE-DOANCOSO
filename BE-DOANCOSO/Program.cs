var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    
    _= endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}");
    
    _= endpoints.MapControllerRoute(
        name: "trang-chu",
        pattern: "trang-chu",
        defaults: new { controller = "Home", action = "Index" });
    
    _= endpoints.MapControllerRoute(
        name: "about",
        pattern: "about",
        defaults: new { controller = "Home", action = "About" });
    
    _= endpoints.MapControllerRoute(
        name: "services",
        pattern: "services",
        defaults: new { controller = "Home", action = "Service" });
    
    _= endpoints.MapControllerRoute(
        name: "contact",
        pattern: "contact",
        defaults: new { controller = "Home", action = "Contact" });
    
    _= endpoints.MapControllerRoute(
        name: "product",
        pattern: "product",
        defaults: new { controller = "Product", action = "Index" });
});
app.Run();