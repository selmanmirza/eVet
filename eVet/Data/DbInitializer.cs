using eVet.Models;
using Microsoft.AspNetCore.Identity;

namespace eVet.Data;

public static class DbInitializer
{
    public static async Task InitializeAsync(IServiceProvider serviceProvider)
    {
        var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
        var context = serviceProvider.GetRequiredService<ApplicationDbContext>();

        string [] roller = {"Admin","Veteriner","Kisi"};

        foreach (string rol in roller)
        {
            if(!await roleManager.RoleExistsAsync(rol))
            {
                await roleManager.CreateAsync(new IdentityRole(rol));
            }
        }

        var adminEmail = "admin@evet.com";
        var adminUser = await userManager.FindByEmailAsync(adminEmail);

        if(adminUser==null)
        {
            var yeniAdmin = new ApplicationUser
            {
                UserName = adminEmail,
                Email = adminEmail,
                EmailConfirmed = true,
                Ad = "Sistem",
                Soyad = "Yöneticisi"
            };

            var nesne = await userManager.CreateAsync(yeniAdmin,"123");

            if(nesne.Succeeded)
            {
                await userManager.AddToRoleAsync(yeniAdmin,"Admin");
            }
     
        }


    }
}