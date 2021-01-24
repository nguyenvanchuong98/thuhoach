using Abp.Application.Services;
using ThuHoach.MultiTenancy.Dto;

namespace ThuHoach.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

