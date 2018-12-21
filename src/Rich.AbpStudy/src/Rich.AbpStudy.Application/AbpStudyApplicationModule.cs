using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Rich.AbpStudy
{
    [DependsOn(
        typeof(AbpStudyCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AbpStudyApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpStudyApplicationModule).GetAssembly());
        }
    }
}