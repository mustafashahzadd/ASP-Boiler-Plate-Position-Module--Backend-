using System.Threading.Tasks;
using MyOrganization.Models.TokenAuth;
using MyOrganization.Web.Controllers;
using Shouldly;
using Xunit;

namespace MyOrganization.Web.Tests.Controllers
{
    public class HomeController_Tests: MyOrganizationWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}