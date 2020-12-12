using System.Threading.Tasks;
using ElectricitytDemo.Configuration.Dto;

namespace ElectricitytDemo.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
