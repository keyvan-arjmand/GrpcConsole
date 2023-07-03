using Microsoft.EntityFrameworkCore;

namespace User
{
    public class DB:DbContext
    {
        public DB(DbContextOptions<DB> options) : base(options)
        {

        }

        public DB()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=teast;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }



        public DbSet<User> users { set; get; }
        public DbSet<Details> details { set; get; }
       
    }
}