using System.Threading.Tasks;
using Abp.Application.Services;
using ShopManage.Sessions.Dto;

namespace ShopManage.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
