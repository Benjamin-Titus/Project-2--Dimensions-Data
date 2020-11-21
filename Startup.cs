using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Project_2__Dimensions_Data.Data;
using Project_2__Dimensions_Data.Models;
using Project_2__Dimensions_Data.Services;
using System;
[assembly: HostingStartup(typeof(Project_2__Dimensions_Data.Data))]


namespace Project_2__Dimensions_Data
{
    public class StartuIdentityHostongStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Project_2_Dimensions_DataDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DefaultConnection")));

                //Role Identity//

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddDefaultUI()
                    .AddEntityFrameworkStores<Project_2_Dimensions_DataDbContext>();
                .AddDefaultTokenProviders();


                services.AddControllersWithViews();
                services.AddRazorPages();

                //Database//
                services.AddDbContext<Project_2_Dimensions_DataDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Project_2_Dimensions_DataDbContextConnection")));

                //Role limitations policies
                services.AddAuthorization(options => {
                    options.AddPolicy("writeonlypolicy", builder => builder.RequireRole("Admin"));
                    options.AddPolicy("usermanagepolicy", builder => builder.RequireRole("Admin"));
                    options.AddPolicy("Readonlypolicy", builder => builder.RequireRole("Employee", "Admin"));
                });
                //Dealing with emails//
                services.AddTransient<IEmailSender, EmailSender>();
                services.Configure<AuthMessageSenderOptions>(Configuration);

            });

        private void AddDefaultTokenProviders()
        {
            throw new NotImplementedException();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
