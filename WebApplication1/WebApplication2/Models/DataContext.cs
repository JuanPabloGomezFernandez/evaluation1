

namespace WebApplication2.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<WebApplication2.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<WebApplication2.Models.Grades> Grades { get; set; }
    }
}