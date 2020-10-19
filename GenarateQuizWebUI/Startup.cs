using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenarateQuizWebUI.Identity;
using GenerateQuiz.BUSINESS.Abstract;
using GenerateQuiz.BUSINESS.Concrete;
using GenerateQuiz.DAL.Abstract;
using GenerateQuiz.DAL.Concrete.EfCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace GenarateQuizWebUI
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
            services.AddSession();

            services.AddControllersWithViews();
            services.AddScoped<IQuizService, QuizManager>();
            services.AddScoped<IQuizDal, EfCoreQuizDal>();
            services.AddDbContext<ApplicationIdentityDbContext>(options =>
            options.UseSqlite(Configuration.GetConnectionString("IdentityConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationIdentityDbContext>()
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;
              
            });

            services.ConfigureApplicationCookie(option =>
            {
                option.LoginPath = "/Account/Login";
                option.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                option.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name = "Quiz.Security.Cookie"
                  

                };
            });
            //services.AddEntityFrameworkSqlite()
            //.AddDbContext<DbContext>(
            //options => { options.UseSqlite($"Data Source=QDb.db"); });

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
           
            app.UseSession();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=index}");
            });
        }
    }
}
