using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ThuHoach.EntityFrameworkCore;
using ThuHoach.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ThuHoach.Web.Tests
{
    [DependsOn(
        typeof(ThuHoachWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ThuHoachWebTestModule : AbpModule
    {
        public ThuHoachWebTestModule(ThuHoachEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ThuHoachWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ThuHoachWebMvcModule).Assembly);
        }
    }
}