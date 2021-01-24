using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ThuHoach.Configuration;
using ThuHoach.Web;

namespace ThuHoach.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ThuHoachDbContextFactory : IDesignTimeDbContextFactory<ThuHoachDbContext>
    {
        public ThuHoachDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ThuHoachDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ThuHoachDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ThuHoachConsts.ConnectionStringName));

            return new ThuHoachDbContext(builder.Options);
        }
    }
}
