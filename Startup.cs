using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Viam.SalesForce.API.Helper;
using Viam.SalesForce.API.Model.Configuration;
using Viam.SalesForce.API.Services;

namespace Viam.SalesForce.API
{
    public class Startup
    {

        public Startup(IConfiguration configuration, ILoggerFactory loggerFactory)
        {
            loggerFactory.CreateLogger(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
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

            // configure strongly typed settings objects
            var appSettingsSection = Configuration.GetSection("Settings");
            services.Configure<AppSettings>(appSettingsSection);

            // configure jwt authentication
            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.SecretKey);

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                   .AddJwtBearer(options =>
                   {
                       options.TokenValidationParameters = new TokenValidationParameters
                       {
                           ValidateIssuer = true,
                           ValidateAudience = true,
                           ValidateLifetime = true,
                           ValidateIssuerSigningKey = true,
                           ValidIssuer = Configuration["AppSettings:Issuer"],
                           ValidAudience = Configuration["AppSettings:Issuer"],
                           IssuerSigningKey = new SymmetricSecurityKey(key)
                       };
                   });

            //services.Configure<ConfigurationModel>(Configuration.GetSection("Settings"));
            var Settings = Configuration.GetSection("Settings");
            services.Configure<ConfigurationModel>(Settings);

            //services.AddScoped<IUserService, UserService>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
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

            app.UseAuthentication();
            app.UseMvc();
            loggerFactory.AddFile(Configuration.GetSection("Logging"));
            app.UseSwagger();
            app.UseSwaggerUI(s =>
            {
                s.RoutePrefix = "swagger";
                s.SwaggerEndpoint("../swagger/v1/swagger.json", "V1 SalesForceAPI");
                s.InjectStylesheet("../css/swagger.min.css");
            });
        }
    }
}
