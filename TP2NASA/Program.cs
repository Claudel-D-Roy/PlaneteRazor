using Microsoft.EntityFrameworkCore;
using TP2NASA.Data;
using TP2NASA.Services;
/// <summary>
/// Auteur: Claudel D. Roy, Willaim Jubinville, Mathieu Duval
/// Description: Collection de tous les services pour les pages du site.
/// Date: 11-25-2022
/// </summary>
/// 
var builder = WebApplication.CreateBuilder(args);

#region Services
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped<IPlan�teService>(service => new Plan�teService(IPlan�teService.Mode.BD, service.GetRequiredService<Plan�tesContext>()));
builder.Services.AddDbContext<Plan�tesContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Plan�tesContext")!.Replace("[PROJET]", builder.Environment.ContentRootPath)));
#endregion

var app = builder.Build();

#region Intergiciels
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
#endregion

string sAuteur = builder.Configuration["Application:Auteur"];

#region Points de terminaison
app.MapRazorPages();
#endregion

app.Run();
