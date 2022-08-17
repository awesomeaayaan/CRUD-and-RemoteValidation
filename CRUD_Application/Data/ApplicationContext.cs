using CRUD_Application.Models;
using CRUD_Application.Models.Account;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Application.Data
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public DbSet<Employee>Employees { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
