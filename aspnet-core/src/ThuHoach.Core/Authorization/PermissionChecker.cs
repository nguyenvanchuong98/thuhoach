using Abp.Authorization;
using ThuHoach.Authorization.Roles;
using ThuHoach.Authorization.Users;

namespace ThuHoach.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
