using System.Threading.Tasks;
using Abp.Application.Services;
using ThuHoach.Sessions.Dto;

namespace ThuHoach.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
