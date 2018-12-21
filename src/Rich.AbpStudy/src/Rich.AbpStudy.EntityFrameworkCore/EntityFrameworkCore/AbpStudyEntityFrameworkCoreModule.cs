using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Rich.AbpStudy.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpStudyCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class AbpStudyEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpStudyEntityFrameworkCoreModule).GetAssembly());
        }
    }
}