using HRManagementSystem.Data.Context;
using HRManagementSystem.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
public static class SqlClientRegistrationExtension
{
    public static void AddDatabaseConnection(this IServiceCollection services)
    {
        IConfiguration config;

        using (var serviceProvider = services.BuildServiceProvider())
        {
            config = serviceProvider.GetService<IConfiguration>();
        }

        services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

        services.AddIdentity<ApplicationUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false)
       .AddDefaultTokenProviders()
       .AddEntityFrameworkStores<ApplicationDBContext>();

    }
}