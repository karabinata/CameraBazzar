using CameraBazzar.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CameraBazzar.Data
{
    public class CameraBazzarDbContext : IdentityDbContext<User>
    {
        public CameraBazzarDbContext(DbContextOptions<CameraBazzarDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
