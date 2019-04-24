using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace umitPenAluminyum.Models
{
    public partial class UmitPenDB : DbContext
    {
        public UmitPenDB()
            : base("name=UmitPenDB")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            throw new UnintentionalCodeFirstException();
        }


        public DbSet<Article> Articles { get; set; }
        public DbSet<Config> Configs { get; set; }
        public DbSet<Slider> Sliders { get; set; }
    }
}
