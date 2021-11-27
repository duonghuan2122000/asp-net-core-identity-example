using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace DBHuan.AspNetIdentity.HttpApi
{
    /// <summary>
    /// DbContext
    /// </summary>
    /// created by: dbhuan 26/11/2021
    public class DBHuanIdentityDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        /// <summary>
        /// Hàm khởi tạo
        /// </summary>
        /// created by: dbhuan 26/11/2021
        public DBHuanIdentityDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasCharSet("utf8");

            builder.ApplyConfiguration(new AppUserConfiguration());
            builder.ApplyConfiguration(new AppRoleConfiguration());

            builder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            builder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles")
                .HasKey(x => new
                {
                    x.UserId,
                    x.RoleId
                });
            builder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins")
                .HasKey(x => x.UserId);

            builder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            builder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens")
                .HasKey(x => x.UserId);
        }
    }
}
