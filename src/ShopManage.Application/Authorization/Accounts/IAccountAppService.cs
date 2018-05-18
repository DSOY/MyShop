using System.Threading.Tasks;
using Abp.Application.Services;
using ShopManage.Authorization.Accounts.Dto;

namespace ShopManage.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
