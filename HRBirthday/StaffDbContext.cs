using HRBirthday.Entity;
using Microsoft.EntityFrameworkCore;

public class StaffDbContext : DbContext
{
    public StaffDbContext(DbContextOptions<StaffDbContext> options) : base(options)
    {

    }
    public DbSet<Staff> Hrstaff { get; set; }
}