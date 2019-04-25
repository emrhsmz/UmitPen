namespace umitPenAluminyum.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Article
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [Column(TypeName = "text")]
        public string Text { get; set; }

        [StringLength(50)]
        public string HeaderText { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? ReadCount { get; set; }

        public bool? isDeleted { get; set; }
    }
}
