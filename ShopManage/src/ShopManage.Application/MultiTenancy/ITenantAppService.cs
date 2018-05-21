using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ShopManage.MultiTenancy.Dto;

namespace ShopManage.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
