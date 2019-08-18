using GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using GraphQlDemo.Products;
using GraphQlDemo.Products.Mappings;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace GraphQlDemo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));
            services.AddScoped<ProductSchema>();
            services.AddScoped<IProductPropertyMapper, MessageProductPropertyMapper>();
            services.AddScoped<IProductPropertyMapper, AttributeProductPropertyMapper>();
            services.AddTransient<Func<string, IProductPropertyMapper>>(provider => (value) =>
            {
                var mappers = provider.GetServices<IProductPropertyMapper>();
                return mappers.FirstOrDefault(x => x.AppliesTo(value));
            });
            
            services.AddGraphQL(o => o.ExposeExceptions = false).AddGraphTypes(ServiceLifetime.Scoped);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseHsts();
            app.UseHttpsRedirection();
            app.UseGraphQL<ProductSchema>();
            app.UseGraphQLPlayground(options: new GraphQLPlaygroundOptions());
            app.UseMvc();
        }
    }
}
