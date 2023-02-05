using MentorFrontToBack.DataAccessLayer;
using MentorFrontToBack.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using System.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var conString = builder.Configuration["ConnectionStrings:Default"];
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(conString));
var app = builder.Build();

app.UseStaticFiles();
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{Id?}");
//app.MapControllerRoute("default", "{controller=Teachers}/{action=Index}/{Id?}");
//app.MapControllerRoute("default", "{controller=EventsPage}/{action=Index}/{Id?}");
app.Run();
