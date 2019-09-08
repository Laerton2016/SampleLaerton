using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebAspNet_Core.Context;
using Microsoft.EntityFrameworkCore;
using WebAspNet_Core.Interface;
using WebAspNet_Core.Repository;

namespace WebAspNet_Core
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            var connection = @"Server=DESKTOP-BGBIQTU;user=sa;password=sil495798;Database=TokenizationService.DAO.TokenVault;Trusted_Connection=True;";
            services.AddDbContext<TokenizationServiceDAOTokenVaultContext>(o => o.UseSqlServer(connection));
            services.AddScoped<IMappingLgpdtokenRepository, MappingLgpdtokenRepository>();
            services.AddScoped<IMappingPaymentTokenRepository, MappingPaymentTokenRepository>();
            services.AddScoped<IOtpadministrationRepository, OtpadministrationRepository>();
            services.AddScoped<ITokenRequestorRegistrationRepository, TokenRequestorRegistrationRepository>();
            services.AddScoped<ITokenServiceProviderConfigRepository, TokenServiceProviderConfigRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
