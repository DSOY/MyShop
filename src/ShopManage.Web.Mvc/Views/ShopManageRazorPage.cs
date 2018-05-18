using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace ShopManage.Web.Views
{
    public abstract class ShopManageRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ShopManageRazorPage()
        {
            LocalizationSourceName = ShopManageConsts.LocalizationSourceName;
        }
    }
}
