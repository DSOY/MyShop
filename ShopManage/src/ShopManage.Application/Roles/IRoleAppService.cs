using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ShopManage.Authorization.Roles;
using ShopManage.Roles.Dto;

namespace ShopManage.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
        Task<Role> GetTaskByName(string name);
    }
}
