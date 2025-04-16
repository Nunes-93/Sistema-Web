using Microsoft.EntityFrameworkCore;
using MySite.Data;
using MySite.Servicos;

var builder = WebApplication.CreateBuilder(args);

// Configurar o DbContext
builder.Services.AddDbContext<MySiteContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("MySiteContext"),
        new MySqlServerVersion(new Version(8, 0, 23)),
        builder => builder.MigrationsAssembly("MySite")
    )
);

// Registrar o SeedingService
builder.Services.AddScoped<SeedingService>();
builder.Services.AddScoped<VendedorServico>();

// Adicionar serviços ao contêiner
builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var seedingService = scope.ServiceProvider.GetRequiredService<SeedingService>();
    seedingService.Seed();
}

// Configurar o pipeline de requisições HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // O valor padrão do HSTS é 30 dias.
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();