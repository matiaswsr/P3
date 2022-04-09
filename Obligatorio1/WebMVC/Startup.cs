using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasosUso;
using Repositorios;
using Dominio.InterfacesRepositorio;

namespace WebMVC
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddScoped<IManejadorUsuario, ManejadorUsuario>();
            services.AddScoped<IRepositorioUsuario, RepositorioUsuario>();
            services.AddScoped<IManejadorPlanta, ManejadorPlanta>();
            services.AddScoped<IRepositorioPlanta, RepositorioPlanta>();
            services.AddScoped<IManejadorTipoPlanta, ManejadorTipoPlanta>();
            services.AddScoped<IRepositorioTipoPlanta, RepositorioTipoPlanta>();
            services.AddScoped<IManejadorFichaCuidados, ManejadorFichaCuidados>();
            services.AddScoped<IRepositorioFichaCuidados, RepositorioFichaCuidados>();
            services.AddScoped<IManejadorCompra, ManejadorCompra>();
            services.AddScoped<IRepositorioCompra, RepositorioCompra>();

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
            }
            
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
