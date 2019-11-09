using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Pabeda.Projem.Business.Abstract;
using Pabeda.Projem.Business.Concrete;
using Pabeda.Projem.DataAccess.Abstract;
using Pabeda.Projem.DataAccess.Concrete.EntityFramework;

namespace Pabeda.Projem.WebAPI
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
            services.AddScoped<IOkulService, OkulManager>();
            services.AddScoped<IOkulDAL, EFOkulDAL>();

            services.AddScoped<IOgrenciService, OgrenciManager>();
            services.AddScoped<IOgrenciDAL, EFOgrenciDAL>();

            services.AddScoped<IOgretmenService, OgretmenManager>();
            services.AddScoped<IOgretmenDAL, EFOgretmenDAL>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
