using Abp.AspNetCore.Mvc.ViewComponents;

namespace ShopManage.Web.Views
{
    public abstract class ShopManageViewComponent : AbpViewComponent
    {
        protected ShopManageViewComponent()
        {
            LocalizationSourceName = ShopManageConsts.LocalizationSourceName;
        }
    }
}
