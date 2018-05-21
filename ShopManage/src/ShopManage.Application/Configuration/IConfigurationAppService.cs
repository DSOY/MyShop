using System.Threading.Tasks;
using ShopManage.Configuration.Dto;

namespace ShopManage.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
