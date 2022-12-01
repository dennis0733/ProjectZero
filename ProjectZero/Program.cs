using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProjectZero.Areas.Identity.Data;
using ProjectZero.Controllers;
using ProjectZero.Data;
using ProjectZero.Models;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("AddDbContextConnection") ?? throw new InvalidOperationException("Connection string 'AddDbContextConnection' not found.");


builder.Services.AddDbContext<AddDbContext>(options =>
    options.UseNpgsql(connectionString)
    );

builder.Services.AddDbContext<BookDbContext>(options =>
    options.UseNpgsql(connectionString)
    );



builder.Services.AddDefaultIdentity<ProjectZeroUserApplication>(options => {
    
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;

    })
    .AddEntityFrameworkStores<AddDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();
