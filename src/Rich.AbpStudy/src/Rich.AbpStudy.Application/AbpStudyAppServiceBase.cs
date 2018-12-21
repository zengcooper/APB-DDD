using Abp.Application.Services;

namespace Rich.AbpStudy
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class AbpStudyAppServiceBase : ApplicationService
    {
        protected AbpStudyAppServiceBase()
        {
            LocalizationSourceName = AbpStudyConsts.LocalizationSourceName;
        }
    }
}