using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLife.Models
{
    internal class Academy:baseModel
    {
        public string Address { get; set; }
        //relationu bu qurur
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
