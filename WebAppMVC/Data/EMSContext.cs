using Microsoft.EntityFrameworkCore; 
public class EMSContext: DbContext{
    public EMSContext(DbContextOptions<EMSContext>options) : base(options)
    {
        
    }
   // public DbSet<Employee> Employees{get; set;}

}