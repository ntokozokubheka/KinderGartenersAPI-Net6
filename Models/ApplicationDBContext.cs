using Microsoft.EntityFrameworkCore;
using KindergartenAPI.Models;

namespace KindergartenAPI.Models
{
    public class ApplicationDBContext:DbContext
    {

        public ApplicationDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<ChildModel> Children { get; set; } 

    }
}
