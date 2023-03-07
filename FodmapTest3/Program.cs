using FodmapTest3.Data.Services;
using FodmapTest3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using FodmapTest3.Areas.Identity.Data;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//

var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetRequiredService<IConfiguration>();

//DbContext configuration
builder.Services.AddDbContext<FodmapDbContext>(item => item.UseSqlServer(builder.Configuration.GetConnectionString("myconn")));

// Service configuration
builder.Services.AddScoped<IArticlesService, ArticlesService>();
builder.Services.AddScoped<IYellowFodmapsService, YellowFodmapsService>();
builder.Services.AddScoped<IRedFodmapsService, RedFodmapsService>();

//DbContext configuration Identity
builder.Services.AddDbContext<IdentityDbContext>(item => item.UseSqlServer(builder.Configuration.GetConnectionString("IdentityDbContextConnection")));

//Identity
builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<IdentityDbContext>();



//

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();

app.UseAuthorization();

app.MapRazorPages();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Articles}/{action=Index}/{id?}");

app.Run();
