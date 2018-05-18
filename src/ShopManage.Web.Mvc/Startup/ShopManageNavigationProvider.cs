using Abp.Application.Navigation;
using Abp.Localization;
using ShopManage.Authorization;

namespace ShopManage.Web.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    public class ShopManageNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Home,
                        L("HomePage"),
                        url: "",
                        icon: "home",
                        requiresAuthentication: true
                    )
                ).AddItem(
                        new MenuItemDefinition(
                            PageNames.Product,
                            new FixedLocalizableString("商品目录"),
                            url: "#",
                            icon: "info"
                        ).AddItem(
                            new MenuItemDefinition(
                                PageNames.Product,
                                new FixedLocalizableString("商品管理"),
                                url: "Product",
                                icon: "info"
                            )
                        ).AddItem(
                            new MenuItemDefinition(
                                PageNames.Category,
                                new FixedLocalizableString("商品分类"),
                                url: "#",
                                icon: "info"
                            )
                        )
                ).AddItem(
                        new MenuItemDefinition(
                            PageNames.About,
                            L("销售管理"),
                            url: "#",
                            icon: "info",
                            requiredPermissionName: PermissionNames.Pages_Tenants
                        ).AddItem(
                            new MenuItemDefinition(
                                PageNames.About,
                                L("商品目录"),
                                url: "#",
                                icon: "info",
                                requiredPermissionName: PermissionNames.Pages_Tenants
                            )
                        ).AddItem(
                            new MenuItemDefinition(
                                PageNames.About,
                                L("商品目录"),
                                url: "#",
                                icon: "info",
                                requiredPermissionName: PermissionNames.Pages_Tenants
                            )
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Tenants,
                        L("Tenants"),
                        url: "Tenants",
                        icon: "business",
                        requiredPermissionName: PermissionNames.Pages_Tenants
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Users,
                        L("Users"),
                        url: "Users",
                        icon: "people",
                        requiredPermissionName: PermissionNames.Pages_Users
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Roles,
                        L("Roles"),
                        url: "Roles",
                        icon: "local_offer",
                        requiredPermissionName: PermissionNames.Pages_Roles
                    )
                )
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.About,
                        L("About"),
                        url: "About",
                        icon: "info"
                    )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, ShopManageConsts.LocalizationSourceName);
        }
    }
}
