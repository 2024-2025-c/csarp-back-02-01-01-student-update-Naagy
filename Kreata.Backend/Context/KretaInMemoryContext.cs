using Microsoft.EntityFrameworkCore;
using Kreata.Backend.Datas.Entities;

namespace Kreata.Backend.Context
{
    public class KretaInMemoryContext : DbContext
    {
        public KretaInMemoryContext(DbContextOptions<KretaInMemoryContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Parent> Parents { get; set; } 
    }
}
