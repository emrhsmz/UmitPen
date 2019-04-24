using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace umitPenAluminyum.Models
{
    public partial class Slider
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public bool isDeleted { get; set; }
        public DateTime CreateDate { get; set; }

    }
}