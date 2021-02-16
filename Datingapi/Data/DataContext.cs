using Datingapi.Entities;
using Microsoft.EntityFrameworkCore;

namespace Datingapi.Data
{

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<AppUser> Users { get; set; }
    }
}