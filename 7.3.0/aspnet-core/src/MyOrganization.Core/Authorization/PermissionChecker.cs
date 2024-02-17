using Abp.Authorization;
using MyOrganization.Authorization.Roles;
using MyOrganization.Authorization.Users;

namespace MyOrganization.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
