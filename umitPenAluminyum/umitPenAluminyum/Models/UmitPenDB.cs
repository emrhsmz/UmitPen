    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

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
            throw new UnintentionalCodeFirstException();
        }


        public DbSet<Article> Articles { get; set; }
        public DbSet<Config> Configs { get; set; }
        public DbSet<Slider> Sliders { get; set; }
    }
}
