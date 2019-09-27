

namespace WebApplication1.Models
{
    using System.Data.Entity;

    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {
                
        }

        public System.Data.Entity.DbSet<WebApplication1.Grades> Grades { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.Student> Students { get; set; }
    }
}




