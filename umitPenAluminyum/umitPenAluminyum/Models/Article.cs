using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace umitPenAluminyum.Models
{
    public partial class Article
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string HeaderText { get; set; }
        public DateTime CreateDate { get; set; }
        public int ReadCount { get; set; }
        public bool isDeleted { get; set; }

    }
}