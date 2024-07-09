using Microsoft.EntityFrameworkCore;

namespace IndoorDesign.Data;

public class SqliteDbContext : DbContext
{
    public DbSet<MaterialTypePo> MaterialType { get; set; }
    
    public DbSet<MaterialPo> Material { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MaterialTypePo>().ToTable("MaterialType");
        modelBuilder.Entity<MaterialPo>().ToTable("Material");
    }
}