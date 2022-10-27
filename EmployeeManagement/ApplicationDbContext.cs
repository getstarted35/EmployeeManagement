using EmployeeManagement.Shared;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        //Employee
        public virtual DbSet<Employee> Employee {get; set;}

        //Deparment
        public virtual DbSet<Deparment> Deparment {get; set;}
    }
}
