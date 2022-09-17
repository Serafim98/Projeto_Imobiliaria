using Microsoft.EntityFrameworkCore;
using Projeto_Imobiliaria.DBContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
/*builder.Services.AddDbContext<ClienteContext>
    (options => options.UseSqlServer("Data Source=coredbserverimobiliariaperseverare.database.windows.net,1433;Initial Catalog=Imobiliaria;User ID=AdminImob;Password=40028922Play"));
builder.Services.AddDbContext<ImovelContext>
    (options => options.UseSqlServer("Data Source=coredbserverimobiliariaperseverare.database.windows.net,1433;Initial Catalog=Imobiliaria;User ID=AdminImob;Password=40028922Play"));
*/

builder.Services.AddDbContext<ClienteContext>
    (options => options.UseSqlServer("Data Source=COLABORADOR-02;Initial Catalog=Imobiliaria;Integrated Security=True"));
builder.Services.AddDbContext<ImovelContext>
    (options => options.UseSqlServer("Data Source=COLABORADOR-02;Initial Catalog=Imobiliaria;Integrated Security=True"));

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
