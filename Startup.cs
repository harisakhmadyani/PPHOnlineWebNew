using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using PlgRequest.Data;

namespace PlgRequest
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        //public const string enUSCulture = "en-US";        

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options => {
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            
            // services.Configure<RequestLocalizationOptions>(options =>{
            //     var supportedCultures = new[]
            //     {
            //         new CultureInfo("en-US"),new CultureInfo("fr")
            //     };

            //     options.DefaultRequestCulture = new RequestCulture(culture: "en-US", uiCulture: "en-US");
            //     options.SupportedCultures = supportedCultures;
            //     options.SupportedUICultures = supportedCultures;

            //     options.AddInitialRequestCultureProvider(new CustomRequestCultureProvider(async context =>
            //     {
            //         // My custom request culture logic
            //         return await Task.FromResult(new ProviderCultureResult("en"));
            //     }));
            // });

            services.AddSingleton<IFileProvider>(  
                new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"))
            ); 

            services.AddDistributedMemoryCache();
            services.AddMvc().AddSessionStateTempDataProvider();
            services.AddSession(options => {
                options.Cookie.Name = "_fchans2.Session";
                options.IdleTimeout = TimeSpan.FromDays(1);
            });
           
            services.AddHttpContextAccessor();

            services.Configure<MySetting>(Configuration.GetSection("MySettings"));
            services.AddControllersWithViews();
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
                app.UseDeveloperExceptionPage();
                //app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                // app.UseHsts();
            }
            // app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "PlgRequest/{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
