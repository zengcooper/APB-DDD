using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Rich.AbpStudy.Configuration;
using Rich.AbpStudy.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Rich.AbpStudy.Web.Startup
{
    [DependsOn(
        typeof(AbpStudyApplicationModule), 
        typeof(AbpStudyEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class AbpStudyWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public AbpStudyWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(AbpStudyConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<AbpStudyNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(AbpStudyApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpStudyWebModule).GetAssembly());
        }
    }
}