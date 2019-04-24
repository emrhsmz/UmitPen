using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace umitPenAluminyum.Models
{
    public partial class UmitPenDBEntities : DbContext
    {
        public UmitPenDBEntities()
            : base("name=UmitPenDBEntities")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Config> Configs { get; set; }
        public DbSet<Slider> Sliders { get; set; }

    }
}