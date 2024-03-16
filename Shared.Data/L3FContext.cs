using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace Shared.Data;

public class L3FContext: DbContext
{
    private string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=L3Finance_V8;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
    public DbSet<ContaPagar> ContasAPagar { get; set; }
    public DbSet<RegrasContasPagar> RegraContasAPagar { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ContaPagar>()
            .HasOne(c => c.RegraContasPagar)
            .WithOne(r => r.ContaPagar)
            .HasForeignKey<ContaPagar>(c => c.IdRegraContasPagar);
    }
}
