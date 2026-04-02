using AuthenticationServer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationServer.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        // IdentityDbContext<IdentityUser> provides all the necessary tables for authentication, such as AspNetUsers, AspNetRoles, etc.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<SSOToken> SSOTokens { get; set; }
    }
}
