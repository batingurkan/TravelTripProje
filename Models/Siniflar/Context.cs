
using Microsoft.EntityFrameworkCore;

namespace TravelTripProje.Models.Siniflar
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("server=BATIN-PC\\SQLEXPRESS; database=TravelDb; integrated security=true");

        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdresBlog> AdresBlogs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<iletisim> iletisims { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
    }
}
