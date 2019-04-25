namespace umitPenAluminyum.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class umitPenDBEntities : DbContext
    {
        public umitPenDBEntities()
            : base("name=umitPenDBEntities")
        {
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Config> Configs { get; set; }
        public virtual DbSet<Slider> Sliders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>()
                .Property(e => e.Text)
                .IsUnicode(false);
        }
    }
}
