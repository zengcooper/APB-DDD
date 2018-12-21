using Abp.AspNetCore.Mvc.Views;

namespace Rich.AbpStudy.Web.Views
{
    public abstract class AbpStudyRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected AbpStudyRazorPage()
        {
            LocalizationSourceName = AbpStudyConsts.LocalizationSourceName;
        }
    }
}
