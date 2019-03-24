using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Movies.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.Webpack;

namespace Movies
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = "Server=localhost;Database=MoviesDB;User Id=sa;Password=Docker88!!";

            //UseSqlServer is EntityFrameworkCore method
            services.AddDbContext<MoviesDbContext>(o => o.UseSqlServer(connectionString));

            services.AddMvc();
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // 
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, MoviesDbContext moviesDbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }

            //serves assets from wwwroot folder
            app.UseStaticFiles();
            //Generate data if it doesen't already exist.

            //moviesDbContext.Database.EnsureDeleted();

            app.UseMvc();


        }

    }
}
