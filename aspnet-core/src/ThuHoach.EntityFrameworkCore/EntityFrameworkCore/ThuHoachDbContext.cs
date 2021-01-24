using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ThuHoach.Authorization.Roles;
using ThuHoach.Authorization.Users;
using ThuHoach.MultiTenancy;

namespace ThuHoach.EntityFrameworkCore
{
    public class ThuHoachDbContext : AbpZeroDbContext<Tenant, Role, User, ThuHoachDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ThuHoachDbContext(DbContextOptions<ThuHoachDbContext> options)
            : base(options)
        {
        }
    }
}
