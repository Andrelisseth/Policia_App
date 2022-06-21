using Microsoft.EntityFrameworkCore;
using Policia_App.Data;
using Policia_App.Repository;
using Policia_App.Service;
var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<PoliciaContext>(options =>
options.UseSqlServer("Server=DESKTOP-QO4O4D8;Database=Policia; TrustServerCertificate=true; Trusted_Connection=true; Connection Timeout= 30; Integrated Security=true; Persist Security Info= false; Encrypt= true; MultipleActiveResultSets=true;")

);
//Inyeccion de la dependencia
builder.Services.AddTransient<IPersona, Persona>();








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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Persona}/{action=Index}/{id?}");

app.Run();
