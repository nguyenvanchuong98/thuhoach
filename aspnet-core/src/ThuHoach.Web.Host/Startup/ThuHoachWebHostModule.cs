using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ThuHoach.Configuration;

namespace ThuHoach.Web.Host.Startup
{
    [DependsOn(
       typeof(ThuHoachWebCoreModule))]
    public class ThuHoachWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ThuHoachWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ThuHoachWebHostModule).GetAssembly());
        }
    }
}
