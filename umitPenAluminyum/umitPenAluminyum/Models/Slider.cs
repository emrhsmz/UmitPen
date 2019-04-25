namespace umitPenAluminyum.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Slider
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(150)]
        public string ImagePath { get; set; }

        public DateTime? CreateDate { get; set; }

        public bool? isDeleted { get; set; }
    }
}
