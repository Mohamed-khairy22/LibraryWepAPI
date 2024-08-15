using Microsoft.EntityFrameworkCore;

namespace LibraryWepAPI.Models
{
    public class DBEntity : DbContext
    {
        public DbSet<Boook> Boooks { get; set; }
        public DbSet<Patron> Patrons { get; set; }
        public DBEntity() { }
        public DBEntity(DbContextOptions options):base (options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //options (dbms sql ,
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-FMRLOB8\\MSSQLSERVER1;Initial Catalog=Library;Integrated Security=True;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
