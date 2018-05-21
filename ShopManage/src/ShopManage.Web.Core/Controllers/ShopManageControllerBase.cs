using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ShopManage.Controllers
{
    public abstract class ShopManageControllerBase: AbpController
    {
        protected ShopManageControllerBase()
        {
            LocalizationSourceName = ShopManageConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
