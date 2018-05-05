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
using DryIoc;
using Microsoft.EntityFrameworkCore;

using Sansagol.CyberFox.CyberFoxApi.Models;

namespace Sansagol.CyberFox.CyberFoxApi
{
    public class Startup
    {
        IBinder _Binder = null;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            _Binder = new BaseBindings();
            _Binder.MainContainer.RegisterInstance(configuration);
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            IConfigurationManager man = _Binder.MainContainer.Resolve<IConfigurationManager>();
            services.AddDbContext<CyberFox_DevContext>(options => options.UseSqlServer(man.GetConnectionString()));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
