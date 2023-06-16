using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLife.Models
{
    internal class Category:baseModel
    {
        public bool IsDeleted { get; set; } 
        public List<Academy> Academies { get; set; }  

    }
}
