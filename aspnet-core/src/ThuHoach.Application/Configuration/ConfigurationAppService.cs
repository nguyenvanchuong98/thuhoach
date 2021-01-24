using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ThuHoach.Configuration.Dto;

namespace ThuHoach.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ThuHoachAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
