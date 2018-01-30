using Microsoft.AspNet.Identity.EntityFramework;

namespace AuthApi.DbContext
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base("AuthContext")
        {
        }
    }
}