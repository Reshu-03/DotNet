using Microsoft.EntityFrameworkCore;

namespace Employee.Data;
public class EmpDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }
    // public DbSet<Counter> Counters { get; set; }

    public EmpDbContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=emp_37.db");
    }
}
