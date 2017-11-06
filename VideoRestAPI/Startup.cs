using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using VideoManagerBLL;
using VideoManagerBLL.BusinessObjects;

namespace VideoRestAPI
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
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
               /* var facade = new BLLFacade();
                var vid = facade.VideoService.Create(
                    new VideoBO()
                    {
                        VideoName= "Gremlins",
                        Year = 1997,
                        Genre = "Horror"
                    });
                facade.VideoService.Create(
                    new VideoBO()
                    {
                        VideoName = "How High",
                        Year = 2004,
                        Genre = "Just Terrible"
                    });
                facade.VideoService.Create(
                    new VideoBO()
                    {
                        VideoName = "The Core",
                        Year = 2006,
                        Genre = "End Of Life"
                    });
                facade.VideoService.Create(
                    new VideoBO()
                    {
                        VideoName = "THe Shining",
                        Year = 1989,
                        Genre = "Horror"
                    });
                for (int i = 0; i < 10; i++)
                { 
                facade.OrderService.Create(
                    new OrderBO()
                    {
                        DeliveryDate = DateTime.Now.AddMonths(1),
                        OrderDate = DateTime.Now.AddMonths(-1),
                        VideoId = vid.Id
                    });
            }*/
            }

            app.UseMvc();
        }
    }
}
