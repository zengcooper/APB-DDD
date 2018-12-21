using Abp.Modules;
using Abp.Reflection.Extensions;
using Rich.AbpStudy.Localization;

namespace Rich.AbpStudy
{
    public class AbpStudyCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            AbpStudyLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpStudyCoreModule).GetAssembly());
        }
    }
}