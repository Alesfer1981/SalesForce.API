﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Viam.SalesForce.API.Model.Configuration;

namespace Viam.SalesForce.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }


        public Startup(IConfiguration configuration)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Sales Force API",
                    Version = "v1",
                    TermsOfService = new Uri("https://www.govianex.com"),
                    Contact = new OpenApiContact
                    {
                        Name = "Viamericas - SalesForce API",
                        Email = "customerservice@viamerica.com",
                        Url = new Uri("https://www.govianex.com")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Use under Viamericas permission",
                        Url = new Uri("https://www.govianex.com")
                    },
                    Description = "API restfull to integration process between Viamericas and SalesForce"
                });
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());

                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });

            //var provider = services.BuildServiceProvider().GetRequiredService<IApiVersionDescriptionProvider>();
            //3ra
            //services.AddSwaggerGen(c =>
            //{
            //    //string swaggerJsonBasePath = string.IsNullOrWhiteSpace(c.RoutePrefix) ? "." : "..";
            //    //foreach (var description in provider.ApiVersionDescriptions)
            //    //{
            //    //    c.SwaggerEndpoint($"{swaggerJsonBasePath}/swagger/{description.GroupName}/swagger.json", description.GroupName.ToUpperInvariant());
            //    //}
            //    foreach (var description in provider.ApiVersionDescriptions)
            //    {
            //        c.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", description.GroupName.ToUpperInvariant());
            //    }
            //});
            

            services.Configure<ConfigurationModel>(Configuration.GetSection("Settings"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //will forward proxy headers to the current request. This will help us during the Linux deployment.
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.All
            });

            app.UseAuthentication(); //Indica que para ingresar a la API deberá usar un token, debe ponerse antes del Mvc
            app.UseMvc();
            app.UseSwagger(c =>
            {
                c.RouteTemplate = "SalesForceAPI/swagger/{documentName}/swagger.json";
            });


            //2da
            //app.UseSwaggerUI(c =>
            //{
            //    string swaggerJsonBasePath = string.IsNullOrWhiteSpace(c.RoutePrefix) ? "." : "..";
            //    c.SwaggerEndpoint($"{swaggerJsonBasePath}/swagger/v1/swagger.json", "V1 SalesForceAPI");
            //});

            //1ra
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/SalesForceAPI/swagger/v1/swagger.json", "V1 SalesForceAPI");
                c.RoutePrefix = "SalesForceAPI/swagger";
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
            app.UseMvc();

        }
    }
}