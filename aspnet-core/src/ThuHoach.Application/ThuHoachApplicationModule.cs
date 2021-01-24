using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ThuHoach.Authorization;

namespace ThuHoach
{
    [DependsOn(
        typeof(ThuHoachCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ThuHoachApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ThuHoachAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ThuHoachApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
