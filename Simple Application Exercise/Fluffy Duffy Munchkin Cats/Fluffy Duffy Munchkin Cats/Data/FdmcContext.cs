namespace Fluffy_Duffy_Munchkin_Cats.Data
{
    using Microsoft.EntityFrameworkCore;
    using Models;
    //TODO: Get The Data and DB Models in a separete project
    public class FdmcContext : DbContext
    {
        public DbSet<Cat> Cats { get; set; }

        public FdmcContext()
        {
            
        }
        public FdmcContext(DbContextOptions<FdmcContext> options)
            : base(options)
        {
        }
    }
}