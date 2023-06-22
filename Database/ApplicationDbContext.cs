using Microsoft.EntityFrameworkCore;
using PayrollApp.Models;

namespace PayrollApp.Database;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    public DbSet<Deposit>? Deposits { get; set; }

}