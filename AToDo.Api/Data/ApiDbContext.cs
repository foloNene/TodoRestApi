using AToDo.Api.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AToDo.Api.Data
{
    public class ApiDbContext : IdentityDbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options) 
        {

        }

        public virtual DbSet<ItemData> Items { get; set; }

        public virtual DbSet<RefreshToken> RefreshTokens { get; set; }



    }
}
