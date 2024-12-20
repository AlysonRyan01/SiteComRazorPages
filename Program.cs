using Microsoft.EntityFrameworkCore;
using SiteComRazorPages.Data;

var builder = WebApplication.CreateBuilder(args);
ServiceConfigure(builder);

var app = builder.Build();
AppConfigure(app);

app.Run();

void AppConfigure(WebApplication app)
{
    app.UseHttpsRedirection();
    app.UseStaticFiles();
    
    app.UseAuthentication();
    app.UseAuthorization();

    app.UseRouting();
    app.MapRazorPages();
}

void ServiceConfigure(WebApplicationBuilder builder)
{
    builder.Services.AddRazorPages();
    builder.Services.AddDbContext<DataContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))
    );
}
