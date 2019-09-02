using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.PlatformAbstractions;
using NLog.Extensions.Logging;
using Simon.Dapper;
using Simon.Filter;
using SimonBus_Config.Repositories;
using SimonBus_Config.Services;
using System.IO;
using System.Text;

namespace SimonBus_Config.Web
{
    public class Startup
    {

        public Startup(IHostingEnvironment env)
        {
            var jsonFileName = "appsettings.json";
            if (env.IsStaging() || env.IsProduction())
                jsonFileName = $"appsettings.{env.EnvironmentName}.json";
            var builder = new ConfigurationBuilder()
                 .SetBasePath(env.ContentRootPath)
                 .AddJsonFile(jsonFileName, true, true);
            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(Configuration);
            services.AddOptions();
            services.AddAuthorization();

            var dbconfig = Configuration.GetSection("DatabaseConnection");
            services.AddSimonDapper(dbconfig["ReadConnection"],dbconfig["WriteConnection"]);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);


            services.AddMvc(options =>
            {
                options.Filters.Add<SimonFilter>();
            });
            services.AddSwaggerGen(options =>
            {
                //options.DescribeAllEnumsAsStrings();
                options.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info
                {
                    Title = "Simon_Bus Config API",
                    Version = "v1",
                    Description = "Simon酒店控制系统参数配置平台API",
                    TermsOfService = "http://simonbus.config.cn/"
                });
            });

            //var audienceConfig = Configuration.GetSection("JwtBear");
            //services.AddAuthentication(x =>
            //{
            //    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //})
            //   .AddJwtBearer(o =>
            //   {
            //       o.TokenValidationParameters = new TokenValidationParameters
            //       {
            //           ValidateAudience = true,
            //           ValidateIssuer = true,
            //           ValidateLifetime = true,
            //           ValidateIssuerSigningKey = true,
            //           ValidIssuer = audienceConfig["Issuer"],
            //           ValidAudience = audienceConfig["Audience"],
            //           IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(audienceConfig["Secret"])),
            //           ClockSkew = TimeSpan.FromDays(1)
            //       };
            //       o.Events = new JwtBearerEvents();
            //   });

            services.AddTransient<IUserService, UserService>();


            services.AddTransient<IUserRepository, UserRepository>();

            services.ConfigureSwaggerGen(c =>
            {
                c.IncludeXmlComments(GetXmlCommentsPath(PlatformServices.Default.Application));
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            loggerFactory.AddNLog();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(builder =>
            {
                builder.AllowAnyOrigin();
                builder.AllowAnyHeader();
                builder.AllowAnyMethod();
                builder.AllowCredentials();
            });
            //app.UseExceptionHandler();
            app.UseAuthentication();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
            });

            //app.UseHttpsRedirection();
            app.UseMvc();
        }

        private string GetXmlCommentsPath(ApplicationEnvironment appEnvironment)
        {
            return Path.Combine(appEnvironment.ApplicationBasePath, "SimonBus_Config.Web.xml");
        }
    }
}
