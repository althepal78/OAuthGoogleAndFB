using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OAuthGoogleAndFB.Models;

namespace OAuthGoogleAndFB.Context
{
    public class AppContext : IdentityDbContext<ApiUser>
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
