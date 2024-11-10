using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Detencion> Detenciones { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
}