using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ThuHoach.EntityFrameworkCore
{
    public static class ThuHoachDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ThuHoachDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ThuHoachDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
