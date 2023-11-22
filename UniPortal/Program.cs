using Microsoft.EntityFrameworkCore;
using UniPortal.Areas.Identity.Data;
using UniPortal.DbContexts;

namespace UniPortal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //Add Db Context
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnectionString"));
            });

            builder.Services.AddDbContext<UniPortalContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnectionString"));
            });


            builder.Services
                .AddDefaultIdentity<UniPortalUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<UniPortalContext>();


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

            app.UseAuthentication(); ;

            app.UseAuthorization();

            //redirect user 400-500 codes to home
            //app.UseStatusCodePagesWithRedirects("/");

            /*app.UseStatusCodePages(async context =>
            {
                // Page not found error
                if (context.HttpContext.Response.StatusCode == 404)
                {
                    await Task.Run(() =>
                    {
                        // Your synchronous code here
                        context.HttpContext.Response.Redirect("/");
                    });
                }
            });*/

            app.MapRazorPages();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}");
            
            
            app.MapControllerRoute(
                name: "studentInfo",
                pattern: "Student/{id:int}",
                defaults: new { controller = "Student", action = "Details" }
            );

            app.Run();
        }
    }
}