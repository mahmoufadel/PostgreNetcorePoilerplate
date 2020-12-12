using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ElectricitytDemo.Configuration.Dto;

namespace ElectricitytDemo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ElectricitytDemoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
