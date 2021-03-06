using CrudBike.AppDBContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CrudBike.MappingProfiles;

namespace CrudBike
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            // automapper
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddDbContext<BikeDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Default")));

            // Identity User and Role
              services.AddIdentity<IdentityUser,IdentityRole>()
                    .AddEntityFrameworkStores<BikeDbContext>()
                   .AddDefaultUI() // roles
                   .AddDefaultTokenProviders();   

            // Identity 
      /*    services.AddDefaultIdentity<IdentityUser>()
                .AddEntityFrameworkStores<BikeDbContext>(); */

            services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0);

            // cloudscribe pagination
            services.AddCloudscribePagination();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
                        pattern: "{controller=MotorBike}/{action=Index}/{id?}");
                        endpoints.MapRazorPages();               


            });
        }
    }
}
