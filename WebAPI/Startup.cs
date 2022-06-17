using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Services.Alumno;
using Interfaces.Interfaces;
using System.Data.SqlClient;
using System.Data;

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public Autofac.IContainer ApplicationContainer { get; private set; }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            //Inyecciones
            //var builder = new ContainerBuilder();
            //builder.Populate(services);
            //builder.RegisterType<AlumnoService>().As<IAlumno>().InstancePerDependency();
            SqlConnection conn = new SqlConnection
            {
                ConnectionString = @"Server=localhost\SQLEXPRESS;Initial Catalog=UdeoSolid;Trusted_Connection=true"
            };
            conn.Open();
            //builder.RegisterInstance<IDbConnection>(conn);
            //this.ApplicationContainer = builder.Build();

            services.AddSingleton<IAlumno, AlumnoService>();
   
         
           
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
