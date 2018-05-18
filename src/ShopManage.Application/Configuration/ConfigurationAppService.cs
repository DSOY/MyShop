using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ShopManage.Configuration.Dto;

namespace ShopManage.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ShopManageAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
