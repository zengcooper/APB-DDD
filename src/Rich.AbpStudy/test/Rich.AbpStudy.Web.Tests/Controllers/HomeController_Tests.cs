using System.Threading.Tasks;
using Rich.AbpStudy.Web.Controllers;
using Shouldly;
using Xunit;

namespace Rich.AbpStudy.Web.Tests.Controllers
{
    public class HomeController_Tests: AbpStudyWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
