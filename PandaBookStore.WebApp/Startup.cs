using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using PandaBookStore.Data;
using PandaBookStore.Service;
using PandaBookStore.WebApp.Initializer;
using PandaBookStore.WebApp.Initializers;

namespace PandaBookStore.WebApp
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
            // Add framework services.
            services.AddDbContext<StoreContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("StoreContextConnection")));

            services.AddTransient<StoreContextSeedData>();

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            //services.AddScoped<IBookService, BookStoreService>();            
            
            services.AddMvc();

            AppServiceInitializer.RegisterDI(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, StoreContextSeedData seeder)
        {            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            // insert data into database
            seeder.EnsureSeedData(env.ContentRootPath + "//books").Wait();
            // Init Profile Mappings
            AutoMapperInitializer.RegisterMappings();
        }
    }
}
