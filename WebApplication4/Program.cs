using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;
using WebApplication4.Models.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add Services
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")
    ));
builder.Services.AddTransient<ProjectsRepository>();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
