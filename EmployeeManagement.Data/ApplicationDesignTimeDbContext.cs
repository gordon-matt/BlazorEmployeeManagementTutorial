using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EmployeeManagement.Data
{
    public class ApplicationDesignTimeDbContext : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Server=.;Initial Catalog=EmployeeTutorial;User=sa;Password=Admin@123;Persist Security Info=True;MultipleActiveResultSets=True");
            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}