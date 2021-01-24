using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ThuHoach.Controllers
{
    public abstract class ThuHoachControllerBase: AbpController
    {
        protected ThuHoachControllerBase()
        {
            LocalizationSourceName = ThuHoachConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
