using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Swashbuckle.AspNetCore.Swagger;

using csharp_dotnetcore_projects.Models;
using csharp_dotnetcore_projects.Utils;
using csharp_dotnetcore_projects.Swagger;


namespace csharp_dotnetcore_projects
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
            // Set memory data bases.
            services.AddDbContext<ApplicationDbContext>( options => 
                options.UseInMemoryDatabase("projects"));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // Swagger
            var contact = new Contact() { Name = SwaggerConfiguration.ContactName, Url = SwaggerConfiguration.ContactUrl };
            services.AddSwaggerGen(gen => {
                gen.SwaggerDoc(SwaggerConfiguration.DocNameVersion,
                     new Info
                     {
                         Title = SwaggerConfiguration.DocInfoTitle,
                         Version = SwaggerConfiguration.DocInfoVersion,
                         Description = SwaggerConfiguration.DocInfoDescription,
                         Contact = contact
                     }
                    );
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ApplicationDbContext applicationDbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();

            // Set Mock Data
            MockDataProjects mockDataProjects = new MockDataProjects(applicationDbContext);
            MockDataTasks mockDataTasks = new MockDataTasks(applicationDbContext);
            mockDataProjects.SetData();
            mockDataTasks.SetData();

            // Swagger
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(option => {
                option.SwaggerEndpoint(SwaggerConfiguration.EndpointUrl, SwaggerConfiguration.EndpointDescription);
            });
           
        }
    }
}
