using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace umitPenAluminyum.Models
{
    public partial class Config
    {
        public int ID { get; set; }
        public string Adress { get; set; }
        public string Telephone { get; set; }
        public string Telephone2 { get; set; }
        public string Email { get; set; }
        public string Logo { get; set; }
        public string LogoTag { get; set; }
        public string Instagram { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }
        public string Youtube { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}