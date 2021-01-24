using System.Threading.Tasks;
using ThuHoach.Models.TokenAuth;
using ThuHoach.Web.Controllers;
using Shouldly;
using Xunit;

namespace ThuHoach.Web.Tests.Controllers
{
    public class HomeController_Tests: ThuHoachWebTestBase
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