using Microsoft.AspNetCore.Mvc;

namespace Rich.AbpStudy.Web.Controllers
{
    public class HomeController : AbpStudyControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}