using DIPExample.Models;
using Microsoft.EntityFrameworkCore;

namespace DIPExample.Data
{
    public class UContext : DbContext
    {
        public UContext() { }

        public UContext(DbContextOptions<UContext> options) : base(options)
        { }

        public virtual DbSet<User> Users { get; set; }
    }
}
