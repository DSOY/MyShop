using System.Collections.Generic;
using ShopManage.Roles.Dto;
using ShopManage.Users.Dto;

namespace ShopManage.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
