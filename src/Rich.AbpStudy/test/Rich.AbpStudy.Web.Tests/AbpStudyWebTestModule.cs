using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Rich.AbpStudy.Web.Startup;
namespace Rich.AbpStudy.Web.Tests
{
    [DependsOn(
        typeof(AbpStudyWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class AbpStudyWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpStudyWebTestModule).GetAssembly());
        }
    }
}