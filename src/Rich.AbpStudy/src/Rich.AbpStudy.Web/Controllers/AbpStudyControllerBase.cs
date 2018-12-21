using Abp.AspNetCore.Mvc.Controllers;

namespace Rich.AbpStudy.Web.Controllers
{
    public abstract class AbpStudyControllerBase: AbpController
    {
        protected AbpStudyControllerBase()
        {
            LocalizationSourceName = AbpStudyConsts.LocalizationSourceName;
        }
    }
}