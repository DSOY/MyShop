using Abp.Authorization;
using ShopManage.Authorization.Roles;
using ShopManage.Authorization.Users;

namespace ShopManage.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
