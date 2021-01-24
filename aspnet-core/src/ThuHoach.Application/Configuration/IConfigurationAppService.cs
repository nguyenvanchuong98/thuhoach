using System.Threading.Tasks;
using ThuHoach.Configuration.Dto;

namespace ThuHoach.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
