using Data;
using Microsoft.EntityFrameworkCore;
using Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var services = builder.Services;
services.AddScoped<HamsterService>();
services.AddScoped<GameService>();
services.AddControllersWithViews();
services.AddRazorPages();

services.AddDbContext<HamsterWarsDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HamsterWarsConnection")));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var scopedServices = scope.ServiceProvider;

    using var context = scopedServices.GetRequiredService<HamsterWarsDbContext>();
    context.Database.EnsureCreated();

    SeedData.Initialize(context);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
