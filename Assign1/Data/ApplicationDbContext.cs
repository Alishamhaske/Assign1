using Assign1.Models;
using Microsoft.EntityFrameworkCore;
namespace Assign1.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> op) : base(op)
        {

        }
        public DbSet<EmployeeEF> EmpEF { get; set; }
    }
}
